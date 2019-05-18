using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] list_i = new int[100];
        int[] list_rank = new int[100];
        int[] list_count = new int[100];

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // 랜덤 숫자 100개 생성 및 변수 초기화
            for (int i = 0; i < list_i.Length; i++)
            {
                list_i[i] = random.Next(1, list_i.Length);
                listBox1.Items.Add(list_i[i]);
                list_rank[i] = 1;
                list_count[i] = 0;
            }

            // 카운터 개수 확인
            for (int i = 0; i < list_i.Length; i++)
            {
                for (int j = 0; j < list_i.Length; j++)
                {
                    if(list_i[i] == list_i[j])
                    {
                        list_count[i]++;
                    }
                }
            }

            // 카운터 순위 매기기
            for (int i = 0; i < list_i.Length; i++)
            {
                for (int j = 0; j < list_i.Length; j++)
                {
                    if (list_count[i] < list_count[j])
                    {
                        list_rank[i]++;
                    }
                }
            }

            for (int i = 0; i < list_i.Length; i++)
            {
                listBox2.Items.Add("숫자:" + list_i[i] + " 개수:" + list_count[i] + " 순위:" + list_rank[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
