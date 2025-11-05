using BusinessObject;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public partial class frmBirdDetail : Form
    {

        public frmBirdDetail()
        {
            InitializeComponent();
        }
        IBirdRepo birdRepo = new BirdRepo();
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Bird BirdInfo { get; set; }
        public IBirdRepo IBirdRepository { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
        private Image birdImage;
        private void frmBirdDetail_Load(object sender, EventArgs e)
        {
            txtBirdID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true) // Update mode
            {
                // Show bird information for updating
                txtBirdID.Text = BirdInfo.BirdId.ToString();
                txtBirdName.Text = BirdInfo.BirdName.ToString();
                txtOrigin.Text = BirdInfo.Origin.ToString();
                txtPrice.Text = BirdInfo.Price.ToString();

                var BirdList = birdRepo.GetBirds();
                foreach (var bird in BirdList)
                {
                    Image image = Image.FromFile(bird.Picture);
                    image.Tag = Path.GetFileName(bird.Picture); // Lưu tên tệp tin như một dữ liệu phụ

                    // Truy xuất tên tệp tin từ đối tượng Image
                    string fileName = image.Tag.ToString();

                    // Assign the image to the field
                    if (bird.BirdId == BirdInfo.BirdId)
                    {
                        pictureBoxBird.Image = image;
                        txtFile.Text = fileName;

                    }
                }



            }
        }

        //------------------------------------------------------



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFile.Text; // Lấy đường dẫn tệp tin từ pictureBoxBird

                var bird = new Bird
                {
                    // Lấy thông tin chim từ các ô văn bản
                    BirdId = int.Parse(txtBirdID.Text),
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
    }

}
