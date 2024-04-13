using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNum1 = dice.Next(1, 7);
            int randomNum2 = dice.Next(1, 7);
            switch (randomNum1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-one (1).png";
                    pictureBox1.SizeMode  = PictureBoxSizeMode.StretchImage; 
                    break;
                 case 2: pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-two.png";
                    pictureBox1.SizeMode =(PictureBoxSizeMode.StretchImage);
                    break;
                    case 3:
                    pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-three.png";
                    pictureBox1.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                    case 4:
                    pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-four.png";
                    pictureBox1.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                    case 5:
                    pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-five.png";
                    pictureBox1.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                    case 6:
                    pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-six.png";
                    pictureBox1.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-one (1).png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;


                      
            }
            switch (randomNum2)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-one (1).png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-two.png";
                    pictureBox2.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-three.png";
                    pictureBox2.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                case 4:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-four.png";
                    pictureBox2.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                case 5:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-five.png";
                    pictureBox2.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-six.png";
                    pictureBox2.SizeMode = (PictureBoxSizeMode.StretchImage);
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\apoor\Downloads\dice-six-faces-one (1).png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            }
        }
}
