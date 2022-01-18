using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainForm
{/// <summary>
///     TODO:
///     Выровнять числа в текстбоксах по центру - пока не получилось. (Занести обозначения рубля, метра и тд в текстбоксы)
/// Красиво оформить код: поля, модификаторы доступа и тд.
/// Вход по логину и паролю.
/// </summary>
    public partial class MyMainForm : Form
    {
        public Tile CurrentTile = new Tile(); /*?????Как разобраться с полями и доступами к ним??????*/
        public int PriceOne = 0;
        public int CountPack = 0;
        public List<Tile> List = Data.ListTile;
        public MyMainForm()
        {
            InitializeComponent();
            AddTreeNodes();
            SumPurchase.ForeColor = Color.Green;
        }

        private void MyMainForm_Load(object sender, EventArgs e)
        {
            LengthL.Text = "Длина, м:";
            WidthL.Text = "Ширина, м:";
            SizeAddLenghtL.Text = "Длина выч. пл., м:";
            SizeAddWidthL.Text = "Ширина выч.пл., м:";
            label1.Text = "Сумма предполагаемой покупки, руб.: ";
            label2.Text = "Количество необходимых пачек, шт.: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chequeEmpty = new ChequeEmpty();
            if (Basket.FullPrice == 0)
                chequeEmpty.Show();
            else
            {
                var printReceipt = new PrintingReceipt();
                printReceipt.Show();

                Basket.FullPrice = 0;
                SumPurchase.Text = (Basket.FullPrice).ToString();
                Reset();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket.FullPrice += PriceOne;
            SumPurchase.Text = (Basket.FullPrice).ToString();
            CurrentTile.Count -= CountPack;
            Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket.FullPrice = 0;
            SumPurchase.Text = Basket.FullPrice.ToString();
        }

        public void Reset()
        {
            numberRequiredBundles.Text = "";
            PriceOneP.Text = "";
            PriceOne = 0;

            CountPack = 0;

            CurrentTile = new Tile();
            LengthT.Text = "";
            WidthT.Text = "";
            SizeAddLenghtT.Text = "";
            SizeAddWidthT.Text = "";
            InfoTile.Text = "Информация  товаре: ";
        }

        void AddTreeNodes()
        {
            var node = AllTile.Nodes.Add("Под камень");
            node.Nodes.Add(List[0].Name);
            node.Nodes.Add(List[1].Name);
            node = AllTile.Nodes.Add("Под мрамор");
            node.Nodes.Add(List[2].Name);
            node.Nodes.Add(List[3].Name);
            node.Nodes.Add(List[4].Name);
            node = AllTile.Nodes.Add("Под дерево");
            node.Nodes.Add(List[5].Name);
            node.Nodes.Add(List[6].Name);
            node = AllTile.Nodes.Add("Под ткань");
            node.Nodes.Add(List[7].Name);
            node.Nodes.Add(List[8].Name);
            node.Nodes.Add(List[9].Name);
            node = AllTile.Nodes.Add("С цветами");
            node.Nodes.Add(List[10].Name);

        }

        private void AllTile_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = AllTile.GetNodeAt(e.Location);
            if (node != null)
            {
                foreach(var u in List)
                {
                    if (node.Text == u.Name)
                    {
                        InfoTile.Text = u.ToString();
                        CurrentTile = u;
                    }
                }
            }
        }

        private void computeOne_Click(object sender, EventArgs e)
        {
           if (!ErrorOutput())
            { 
                CountPack = CalcCountPack();
                numberRequiredBundles.Text = CountPack.ToString();
                PriceOne = CountPack * CurrentTile.PriceOfOnePack;
                PriceOneP.Text = PriceOne.ToString();
            }
        }

        public bool ErrorOutput()
        {
            var inc = new IncorrectData();
            var nep = new NotEnoughProduct();
            var pins = new ProductIsNotSelected();
            if (LengthT.Text == "" || WidthT.Text == "" || SizeAddLenghtT.Text == "" || SizeAddWidthT.Text == "") //проверка на пустую строку
            {
                inc.Show();
                return true;
            }    
            if (CurrentTile.Name == null) //выбран ли товар из списка?
            {
                 pins.Show();
                 return true;
            }
            if (CurrentTile.Count < CalcCountPack()) //хватает ли товаров?
            {
                 nep.Show();
                 return true;
            }
            if (CalcTotalArea() < 0) //вычитаемая площадь не может быть больше полной площади
            {
                 inc.Show();
                 return true;
            }
            return false;
        }

        public int CalcCountPack()
        {
            return Calculator.NumberPacksTiles(CalcTotalArea());
        }

        public double CalcTotalArea()
        {
            var length = int.Parse(LengthT.Text);
            var width = int.Parse(WidthT.Text);
            var addLength = int.Parse(SizeAddLenghtT.Text);
            var addWidth = int.Parse(SizeAddWidthT.Text);
            var totalArea = Calculator.ComputeArea(length, width) - Calculator.ComputeArea(addLength, addWidth);
            return totalArea;
        }

        #region
        private void Lengthl_Click(object sender, EventArgs e)
        {

        }

        private void SizeWT_TextChanged(object sender, EventArgs e)
        {

        }

        private void SizeAddWidthT_TextChanged(object sender, EventArgs e)
        {

        }

        private void SizeAddWidthL_Click(object sender, EventArgs e)
        {

        }

        private void SizeAddLenghtL_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
