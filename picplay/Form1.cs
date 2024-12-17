using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBoxImages_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void ListBoxImages_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void ListBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeimage();
        }
        private void changeimage()
        {
            if (ListBoxImages.SelectedItem != null) // چک کردن انتخاب‌بودن آیتم
            {
                string selectedImagePath = ListBoxImages.SelectedItem.ToString();
                try
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(selectedImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // تنظیم حالت نمایش عکس
                    this.Text = "PicPlay | vahidzahani.ir | " + ListBoxImages.Items.Count.ToString() + " items";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در نمایش عکس: " + ex.Message);
                }
            }

        }
        private void SaveListBoxToFile()
        {
            

            try
            {
                // مسیر فایل
                string filePath = "filelist.txt";

                // باز کردن فایل برای نوشتن
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var item in ListBoxImages.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ذخیره لیست: " + ex.Message);
            }
        }
        private void LoadListBoxFromFile()
        {
            try
            {
                string filePath = "filelist.txt";

                // بررسی وجود فایل
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            ListBoxImages.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری لیست: " + ex.Message);
            }
        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // نشان دادن آیکن کپی
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // دریافت مسیر فایل‌ها
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // فیلتر کردن فایل‌های عکس بر اساس پسوند
            var imageFiles = files.Where(file =>
                Path.GetExtension(file).Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                Path.GetExtension(file).Equals(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                Path.GetExtension(file).Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                Path.GetExtension(file).Equals(".bmp", StringComparison.OrdinalIgnoreCase) ||
                Path.GetExtension(file).Equals(".gif", StringComparison.OrdinalIgnoreCase));

            // اضافه کردن فایل‌های عکس به ListBox
            foreach (var file in imageFiles)
            {
                if (!ListBoxImages.Items.Contains(file)) // جلوگیری از اضافه شدن تکراری
                {
                    ListBoxImages.Items.Add(file);
                }
            }
            ListBoxImages.SelectedIndex = 0;
            SaveListBoxToFile();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListBoxFromFile();
            if (ListBoxImages.Items.Count > 0) { ListBoxImages.SelectedIndex = 0; }
        }

        private void ListBoxImages_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void ListBoxImages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // بررسی اینکه آیا آیتمی انتخاب شده است
                if (ListBoxImages.SelectedItem != null)
                {
                    // حذف آیتم انتخاب‌شده
                    ListBoxImages.Items.Remove(ListBoxImages.SelectedItem);

                    // ذخیره وضعیت جدید لیست‌باکس
                    SaveListBoxToFile();
                    if (ListBoxImages.Items.Count > 0)
                    {
                        ListBoxImages.SelectedIndex = 0;
                        changeimage();
                    }
                }
            }
            if (e.KeyCode==Keys.Down)
            {
                if (ListBoxImages.SelectedIndex == ListBoxImages.Items.Count -1)
                {
                    ListBoxImages.SelectedIndex = 0;
                    e.Handled = true;
                    
                }
            }
        }
    }
}
