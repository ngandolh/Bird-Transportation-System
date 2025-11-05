using BusinessObject;
using Repositories;
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

namespace BTSManagementWinApp
{
    public partial class frmBirdCustomer : Form
    {
        public frmBirdCustomer()
        {
            InitializeComponent();
        }

        IBirdRepo birdRepo = new BirdRepo();
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Bird BirdInfo { get; set; }
        public IBirdRepo IBirdRepository { get; set; }


        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.gif; *.bmp)|*.jpg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBoxBird.Image = Image.FromFile(filePath);

                string fileName = Path.GetFileName(filePath);
                txtFile.Text = fileName;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFile.Text; // Lấy đường dẫn tệp tin từ pictureBoxBird

                var bird = new Bird
                {
                    // Lấy thông tin chim từ các ô văn bản
                    BirdName = txtBirdName.Text,
                    Origin = txtOrigin.Text,
                    Price = double.Parse(txtPrice.Text),
                    Picture = filePath, // Gán tên tệp tin vào cột Picture
                };

                if (InsertOrUpdate == false)
                {  // Tạo một chim mới
                    var birdRepo = new BirdRepo();
                    birdRepo.AddNew(bird);
                }
                else
                {
                    // Cập nhật chim đã tồn tại
                    var birdRepo = new BirdRepo();
                    birdRepo.UpdateBird(bird);
                }

                MessageBox.Show(InsertOrUpdate == false ? "New bird added successfully" : "Bird updated successfully");
                //LoadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new bird" : "Update a bird");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
