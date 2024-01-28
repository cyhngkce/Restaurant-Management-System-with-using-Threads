using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace threadsRestaurantManagement
{
    public partial class Form1 : Form
    {
        private const int WaiterCount = 3;
        private const int ChefCount = 2;
        private int tableCount = 6;

        public int TableCount
        {
            get { return tableCount; }
            set { tableCount = value; }
        }
        private int siparis = 0;
        private int siparis1 = 0;
        private int siparis2 = 0;
        private int siparis3 = 0;
        private int takingOrder = 0;
        private int totalEatingTime = 20000; 
        private int paymentTime = 3000; 

        private int waitingCustomers;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListBox(string text)
        {
            if (listBox1.InvokeRequired)
            {
                Invoke(new Action<string>(UpdateListBox), text);
            }
            else
            {
                listBox1.Items.Add(text);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int totalCustomers = int.Parse(textBox1.Text);

            
            UpdateListBox($"Toplam {totalCustomers} müþteri geldi.");

            if (totalCustomers > TableCount)
            {
                waitingCustomers = totalCustomers - TableCount;

                UpdateListBox($"{totalCustomers - TableCount} müþteri bekletme listesine eklendi.");
                UpdateListBox($"{TableCount} müþteri yerleþtirildi");
                for (int i = 1; i <= TableCount; i++)
                {
                    Button tableButton = GetTableButton(i);
                    if (tableButton != null)
                    {
                        tableButton.BackColor = Color.Green;
                    }
                }
                MessageBox.Show("Müþteriler masalara oturtuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StartWaiterTasks();
                MessageBox.Show("Garsonlar sipariþleri alýyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
                StartChefTasks();

            }
            else if (totalCustomers == TableCount)
            {
                UpdateListBox($"{TableCount} müþteri yerleþtirildi");
                for (int i = 1; i <= TableCount; i++)
                {
                    Button tableButton = GetTableButton(i);
                    if (tableButton != null)
                    {
                        tableButton.BackColor = Color.Green;
                    }
                }
                MessageBox.Show("Müþteriler masalara oturtuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StartWaiterTasks();
                MessageBox.Show("Garsonlar sipariþleri alýyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StartChefTasks();

            }
            else
            {
                UpdateListBox($"{totalCustomers} müþteri yerleþtirildi");
                for (int i = 1; i <= totalCustomers; i++)
                {
                    Button tableButton = GetTableButton(i);
                    if (tableButton != null)
                    {
                        tableButton.BackColor = Color.Green;
                    }
                }
                MessageBox.Show("Müþteriler masalara oturtuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableCount = totalCustomers;

                StartWaiterTasks();
                

                StartChefTasks();

            }
            UpdateWaitingCustomersLabel();
        }
        private Button GetTableButton(int tableNumber)
        {
            return this.Controls.Find($"masa{tableNumber}", true).FirstOrDefault() as Button;
        }
        private Button GetChefButton(int chefNumber)
        {
            return this.Controls.Find($"asci{chefNumber}", true).FirstOrDefault() as Button;
        }
        private Button GetWaiterButton(int waiterNumber)
        {
            return this.Controls.Find($"garson{waiterNumber}", true).FirstOrDefault() as Button;
        }
        private void UpdateWaitingCustomersLabel()
        {
            if (bekleyenMusteri.InvokeRequired)
            {
                Invoke(new Action(UpdateWaitingCustomersLabel));
            }
            else
            {
                bekleyenMusteri.Text = $"{waitingCustomers}";
            }
        }
        public void StartWaiterTasks()
        {
            for (int i = 1; i <= WaiterCount; i++)
            {
                int waiterNumber = i; 
                Task.Run(async () =>
                {
                   
                    ServeCustomers(waiterNumber);
                });

            } 
           
        }

        public void StartChefTasks()
        {

            for (int i = 1; i <= ChefCount; i++)
            {
                int chefNumber = i; 
                

                Task.Run(async() =>
                {
                    
                    PrepareOrders(chefNumber);
                });
            }
        }

        public async Task ServeCustomers(int waiterNumber)
        {
          
            while (TableCount > 0)
            {
                await Task.Delay(2000);

                lock (this)
                {
                    if (TableCount > 0)
                    {
                        UpdateListBox($"Garson {waiterNumber} müþteriden sipariþ aldý. Bekleyen müþteri sayýsý: {--TableCount}");

                        takingOrder++;
                        siparis++;
                        Button waiter = GetWaiterButton(siparis);
                        if (waiter != null)
                        {
                            waiter.BackColor = Color.Black;
                        }
                        Button tableButton = GetTableButton(siparis);
                        if (tableButton != null)
                        {
                            tableButton.BackColor = Color.Yellow;
                        }


                        Task.Run(async () =>
                        {
                            await Task.Delay(totalEatingTime);
                            Eat(waiterNumber);
                        });
                    }

                }
            }
        }

        public async Task PrepareOrders(int chefNumber)
        {

           
            while (takingOrder >= 0)
            {
                await Task.Delay(5000); 

                lock (this)
                {
                    if (takingOrder > 0)
                    {
                        UpdateListBox($"Aþçý {chefNumber} sipariþi hazýrladý. Bekleyen sipariþ sayýsý: {--takingOrder}");
                        Task.Delay(2000);
                        siparis1++;

                        Button chef = GetChefButton(siparis1);
                        if (chef != null)
                        {
                            chef.BackColor = Color.Red;
                        }
                        Button tableButton = GetTableButton(siparis1);
                        if (tableButton != null)
                        {
                            tableButton.BackColor = Color.Blue;
                        }

                        UpdateListBox($"Garson sipariþi götürdü");
                    }
                }
            }
        }

        private void Eat(int waiterNumber)
        {
            lock (this)
            {
                UpdateListBox($"Müþteri yemeðini yiyor. Garson {waiterNumber} masayý boþalttý.");
                siparis2++;

                Button tableButton = GetTableButton(siparis2);
                if (tableButton != null)
                {
                    tableButton.BackColor = Color.White;
                }
             
                Task.Run(async () =>
                {
                    await Task.Delay(paymentTime);
                    Pay(waiterNumber);
                });

            }
        }

        private async void Pay(int waiterNumber)
        {
            siparis = 0;
            siparis1 = 0;
            siparis2 = 0;
            lock (this)
            {

                UpdateListBox($"Müþteri ödeme yaptý. Garson {waiterNumber} masayý topladý ve ödemeyi kasaya getirdi.");
                 Task.Delay(2000);

                if (waitingCustomers > 0)
                {
                    TableCount++;
                    siparis3++;
                    UpdateListBox($"Yeni müþteri oturdu. Bekleyen müþteri sayýsý: {--waitingCustomers}");
                    Button table = GetTableButton(siparis3);
                    if (table != null)
                    {

                        table.BackColor = Color.Green;
                    }

                    StartWaiterTasks();
                    Task.Delay(2000);
                    StartChefTasks();
                }
                UpdateWaitingCustomersLabel();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void garson2_Click(object sender, EventArgs e)
        {
        }

        private void garson3_Click(object sender, EventArgs e)
        {
        }

        private void garson1_Click(object sender, EventArgs e)
        {
        }
    }
}