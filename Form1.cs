using SAV_1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAV_1.Algorithms;

namespace SAV_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private Graphics graphics;
        private List<Element> elements = new List<Element>();
        int tk = 20;

        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                elements.Clear();
                panel1.Refresh();
                var rand = new Random();
                int height = panel1.Height;
                int padding = 30 + 5;
                

                int size = Convert.ToInt32(comboBox1.Text);
                int length = panel1.Bottom;

                for (int i = 0; i < size; i++)
                {
                    var start = new Point(padding, height);
                    int value = height - rand.Next(1,30) * 10;
                    var end = new Point(padding, value);
                    int rvalue = height - value;
                    var element = new Element(start, end, rvalue);
                    elements.Add(element);
                    padding += 40;
                    element.Draw(graphics, tk);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Select Array Size", "Select Array Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text=="Bubble Sort")
            {
                textBox1.Text = "Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if the are in wrong order." +
                    "\r\n\r\nTime Complexity: O(N^2)";

            }
            else if (comboBox2.Text == "Selection Sort")
            {
                textBox1.Text = "Selection Sort algorithm sorts an array by repeatedly finding the minimum element and from the unsorted part and putting it at the beginning." +
                    "\r\n\r\nTime Complexity: O(N^2)";
            }
            else if (comboBox2.Text == "Quick Sort")
            {
                textBox1.Text = "Quicksort is a divide-and-conquer algorithm. It works by selecting the a 'pivot' element from the array and partitioning the other elements into two sub-arrays, according to whether they are less than or greater than the pivot." +
                    "\r\n\r\nTime Complexity: O(N^2)";
            }
            else if (comboBox2.Text == "Merge Sort")
            {
                textBox1.Text = "Merge Sort is a divide-and-conquer algorithm based on the idea of breaking down a list into several sub-lists until each sublist consists of a single element and merging those sublists in a manner that results into a sorted list." +
                    "\r\n\r\nTime Complexity: O(N log(N))";
            }
            else if (comboBox2.Text == "Insertion Sort")
            {
                textBox1.Text = "This is an in-place sorting algorithm based on the idea that one element from the input elements is consumed in each iteration to find its correct position i.e, the position to which it belongs in a sorted array." +
                    "\r\n\r\nTime Complexity: O(N^2)";
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String speed = comboBox3.Text;
            int s;
            if (speed == "Slow")
            {
                s = 700;
            }
            else if (speed=="Normal")
            {
                s = 200;
            }
            else if(speed=="Fast")
            {
                s = 50;
            }
            else
            {
                s = 200;
            }
            try
            {
                String algo = comboBox2.Text;
                if (algo == "") //If No Sorting algorithm is selected 
                {
                    throw new Exception();
                }
                else if (algo == "Bubble Sort")
                {
                    
                    Algorithms.BubbleSort.Sort(elements, graphics, tk,s);
                }
                else if (algo == "Selection Sort")
                {
                    Algorithms.SelectionSort.Sort(elements, graphics, tk,s);
                }
                else if (algo == "Quick Sort")
                {
                    Algorithms.QuickSort.Sort(elements, graphics, tk,s);
                }
                else if (algo == "Insertion Sort")
                {
                    Algorithms.InsertionSort.Sort(elements, graphics, tk,s);
                }
                else if (algo == "Merge Sort")
                {
                    Algorithms.MergeSort.Sort(elements, graphics, tk,s);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please Select Sorting Algorithm", "Select Sorting Algorithm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
         try
            {
                elements.Clear();
                panel1.Refresh();
                
                string[] myText = textBox3.Text.Split(' ');
                int[] arr = new int[myText.Length];

                int height = panel1.Height;
                int padding = 30 + 5;

                for (int i = 0; i < myText.Length; i++)
                {
                    arr[i] = int.Parse(myText[i]);
                }

                int size = arr.Length;
                int length = panel1.Bottom;

                for (int i = 0; i < size; i++)
                {
                    var start = new Point(padding, height);
                    int value = height - arr[i] * 10;
                    var end = new Point(padding, value);
                    int rvalue = height - value;
                    var element = new Element(start, end, rvalue);
                    elements.Add(element);
                    padding += 40;
                    element.Draw(graphics, tk);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Enter Elements Seperated by Space", "Enter Elements Seperated by Space", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
