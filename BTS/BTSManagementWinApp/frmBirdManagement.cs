using BusinessObject;
using ProjectManagementWinApp_NGUYENTHIMINHNGUYET;
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
    public partial class frmBirdManagement : Form
    {
        public event EventHandler Logout;

        IBirdRepo birdRepo = new BirdRepo();
        IEnumerable<Bird> dataSource;
        IEnumerable<Bird> searchResult;
        IEnumerable<Bird> filterResult;
        BindingSource source;
        bool searchBool = false;
        bool filter = false;

        public frmBirdManagement()
        {
            InitializeComponent();
            dgvBird.CellFormatting += dgvBird_CellFormatting;
            txtPicture.TextChanged += txtPicture_TextChanged;
        }

        private void dgvBird_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBird.Columns[e.ColumnIndex].Name == "Picture" && e.Value != null)
            {
                DataGridViewImageCell imageCell = dgvBird.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                imageCell.ImageLayout = DataGridViewImageCellLayout.Stretch; // Chỉnh cỡ hình ảnh về 100%
            }
            // Chỉnh chiều rộng của cột theo tên cột
            string columnName = "Picture"; // Thay thế bằng tên thực tế của cột
            int newWidth = 200; // Chiều rộng mới

            if (dgvBird.Columns.Contains(columnName))
            {
                dgvBird.Columns[columnName].Width = newWidth;
            }
            foreach (DataGridViewColumn column in dgvBird.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Vô hiệu hóa tự động điều chỉnh chiều rộng
                column.Width = newWidth; // Đặt chiều rộng mới cho tất cả các cột
            }

            int newHeight = 100; // Chiều cao mới

            foreach (DataGridViewRow row in dgvBird.Rows)
            {
                row.Height = newHeight;
            }
        }
        private void frmBirdManagement_Load(object sender, EventArgs e)
        {
            LoadBirdList();
            dgvBird.CellDoubleClick += DgvBird_CellDoubleClick;

        }
        public void LoadBirdList()
        {
            try
            {
                var BirdList = birdRepo.GetBirds();
                BindingSource source = new BindingSource();
                source.DataSource = BirdList;
                DataTable dt = new DataTable();
                dt.Columns.Add("BirdId");
                dt.Columns.Add("BirdName");
                dt.Columns.Add("Origin");
                dt.Columns.Add("Price");
                dt.Columns.Add("Picture", typeof(Image));

                txtBirdID.DataBindings.Clear();
                txtBirdName.DataBindings.Clear();
                txtOrigin.DataBindings.Clear();
                txtPicture.DataBindings.Clear();

                txtBirdID.DataBindings.Add("Text", dt, "BirdId");
                txtBirdName.DataBindings.Add("Text", dt, "BirdName");
                txtOrigin.DataBindings.Add("Text", dt, "Origin");
                txtPrice.DataBindings.Add("Text", dt, "Price");
                txtPicture.DataBindings.Add("Image", dt, "Picture");

                foreach (var bird in BirdList)
                {
                    // Convert the image path to a byte array
                    byte[] imageBytes = File.ReadAllBytes(bird.Picture);
                    // Create an Image object from the byte array
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        dt.Rows.Add(bird.BirdId, bird.BirdName, bird.Origin, bird.Price, image);
                    }
                }

                dgvBird.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Birds");
            }
        }
        //public void LoadBirdList()
        //{
        //    try
        //    {
        //        var BirdList = birdRepo.GetBirds();
        //        BindingSource source = new BindingSource();
        //        source.DataSource = BirdList;
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("BirdId");
        //        dt.Columns.Add("BirdName");
        //        dt.Columns.Add("Origin");
        //        dt.Columns.Add("Picture", typeof(Image));


        //        txtBirdID.DataBindings.Clear();
        //        txtBirdName.DataBindings.Clear();
        //        txtOrigin.DataBindings.Clear();
        //        txtPicture.DataBindings.Clear();


        //        txtBirdID.DataBindings.Add("Text", dt, "BirdId");
        //        txtBirdName.DataBindings.Add("Text", dt, "BirdName");
        //        txtOrigin.DataBindings.Add("Text", dt, "Origin");
        //        txtPicture.DataBindings.Add("Image", dt, "Picture");





        //        foreach (var bird in BirdList)
        //        {
        //            Image image = Image.FromFile(bird.Picture);
        //            dt.Rows.Add(bird.BirdId, bird.BirdName, bird.Origin, image);

        //        }


        //        dgvBird.DataSource = dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error on load list of Birds");
        //    }
        //}

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {
            string picturePath = txtPicture.Text;
            if (File.Exists(picturePath))
            {
                Image picture = Image.FromFile(picturePath);
                txtPicture.Image = picture;
            }
            else
            {
                txtPicture.Image = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Bird Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var p = new Bird
                {
                    BirdId = int.Parse(txtBirdID.Text),
                };
                birdRepo.DeleteBird(p);
                LoadBirdList();
            }
        }
        private void ClearText()
        {
            txtBirdID.Text = "";
            txtBirdName.Text = "";
            txtOrigin.Text = "";
            txtPicture.Text = "";
            txtPrice.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearText();
            frmBirdCreate frmBirdDetail = new frmBirdCreate
            {
                Text = "Add bird",
                InsertOrUpdate = false,
                IBirdRepository = birdRepo
            };
            if (frmBirdDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBirdList();
                //Set focus car inserted 
                //source.Position = source.Count - 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBirdName.Text == "" || txtOrigin.Text == "" || txtPicture.Text == "")
            {
                MessageBox.Show("All fields are required!", "Bird Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var p = new Bird
                {
                    //ProductId = int.Parse(txtProductId.Text),
                    BirdId = int.Parse(txtBirdID.Text),
                    BirdName = txtBirdName.Text,
                    Origin = txtOrigin.Text,
                    Price = double.Parse(txtPrice.Text),
                    Picture = txtPicture.Text,
                };
                birdRepo.SaveBird(p);

                btnCreate.Text = "Create";
                btnSave.Enabled = false;

                LoadBirdList();
            }
        }
        private void DgvBird_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBirdDetail frmBirdDetail = new frmBirdDetail
            {
                Text = "Update project",
                InsertOrUpdate = true, // Update
                BirdInfo = GetBirdObject(),
                IBirdRepository = birdRepo
            };
            if (frmBirdDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBirdList();
                //Set focus car updated 
                //source.Position = source.Count - 1;
            }
        }
        private Bird GetBirdObject()
        {
            Bird bird = null;
            try
            {
                bird = new Bird
                {

                    BirdId = int.Parse(txtBirdID.Text),
                    BirdName = txtBirdName.Text,
                    Origin = txtOrigin.Text,
                    Price = double.Parse(txtPrice.Text),
                    Picture = txtPicture.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get project");
            }
            return bird;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Đóng form 
            // Sử dụng Hide() để ẩn form đăng nhập thay vì Close()
            this.Hide();

            // Tạo một thể hiện của frmCustomer
            frmCustomer customerForm = new frmCustomer();
            // Hiển thị frmCustomer
            customerForm.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the frmBirdManagement form

            // Show the frmOrderAdmin form
            frmOrderAdmin frmOrderAdmin = new frmOrderAdmin();
            frmOrderAdmin.Logout += FrmOrderAdmin_Logout; // Subscribe to the Logout event
            frmOrderAdmin.ShowDialog();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide(); // Hide the frmBirdManagement form

                // Show the login form
                frmLogin loginForm = new frmLogin();
                loginForm.Logout += FrmLogin_Logout; // Subscribe to the Logout event
                loginForm.ShowDialog();
            }
        }

        private void FrmLogin_Logout(object sender, EventArgs e)
        {
            // When the login form is closed, we want to show the frmBirdManagement form again.
            this.Show();
        }

        private void FrmOrderAdmin_Logout(object sender, EventArgs e)
        {
            // When the frmOrderAdmin form logs out, we want to show the frmLogin form again.
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();

        }

    }
}
