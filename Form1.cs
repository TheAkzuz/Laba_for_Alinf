namespace Laba_1
{
    public partial class Form1 : Form
    {

        class Cylinder
        {

            public int R = 0;
            public int H = 0;

            public Cylinder(int r, int h)
            {
                R = r;
               H = h;

            }

            public int analiz_S()
            {
                // Pi=3,18 , мы его округлим до 3, дл€ int

                int S = 2*3 * this.H * this.R;
                return S;
            }

            public int Re_R
            {
                get
                {
                    return R;
                 }
                set { R = value; }
            }
            public int Re_H
            {
                get { return H; }
                set { H = value; }
            }

            public int analiz_V ()
            {
                int V = this.H * analiz_S();

                return V;
            }

            public string analis_Syn_and_Cyrs()
            {
                if(this.R < 1 )
                {
                    return "—фера не поместитьс€ в цилиндр";
                }
                else
                {
                    return "—фера поместитьс€ в цилиндр";
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            Cylinder one_cy = new Cylinder(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            listView1.Items.Add("S="+one_cy.analiz_S()+"\nV="+one_cy.analiz_V());

            label4.Text = one_cy.analis_Syn_and_Cyrs();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}