using QuanLyQuanKaraoke.DAO;
using QuanLyQuanKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke
{
    public partial class fAdmin : Form
    {
        #region Variables
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        #endregion
        public fAdmin()
        {
            InitializeComponent();
            //DataGridView
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvCategory.DataSource = categoryList;
            //Load
            LoadListFood();
            LoadAccount();
            LoadCategory();
            LoadCategoryIntoCombobox(cbCategory);
            //AddBinding
            AddFoodBinding();
            AddAccountBinding();
            AddCategoryBinding();
        }
        #region Methods
        #region Binding
        void AddFoodBinding()
        {
            txbNameFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbIdFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "IDFood", true, DataSourceUpdateMode.Never));
            nudPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryBinding()
        {
            txbIdCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbNameCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txbAccountUser.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "userName", true, DataSourceUpdateMode.Never));
            txbAccountDisplay.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "displayName", true, DataSourceUpdateMode.Never));
            txbAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "typeAccount", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region Load
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        #endregion
        #region ButtonFood Methods
        //Trả về danh sách food
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        #endregion
        #region ButtonAccount Methods
        //Thêm tài khoản
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }
        //Sửa tài khoản
        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }
        //Xóa tài khoản
        void DeleteAccount(string userName)
        {
            userName = userName.Replace(" ", String.Empty);
            try
            {
                if (fLogin.userNameP == (userName))
                {
                    MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                    return;
                }
                else
                {
                    if (AccountDAO.Instance.DeleteAccount(userName))
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại");
                    }
                }
                LoadAccount();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        //Đặt lại mật khẩu
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        #endregion
        #region ButtonCategory Methods
        //Thêm danh mục
        void AddCategory(string nameCategory)
        {
            if (CategoryDAO.Instance.InsertCategory(nameCategory))
            {
                MessageBox.Show("Thêm danh mục thành công");
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }

            LoadCategory();
        }
        //Xóa danh mục
        void DeteleCategory(int id)
        {
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }

            LoadCategory();
        }
        //Sửa danh mục
        void EditCategory(int id, string name)
        {
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Sửa danh mục thất bại");
            }

            LoadCategory();
        }
        #endregion
        #endregion
        #region Events

        #region ButtonAccount
        //Button thêm account
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountUser.Text;
            string displayName = txbAccountDisplay.Text;
            int type = Convert.ToInt32(txbAccountType.Text);
            AddAccount(userName, displayName, type);
        }
        //Button sửa account
        private void btnRepairAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountUser.Text;
            string displayName = txbAccountDisplay.Text;
            int type = Convert.ToInt32(txbAccountType.Text);

            EditAccount(userName, displayName, type);
        }
        //Button xóa account
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountUser.Text;

            DeleteAccount(userName);
        }
        //Button đặt lại mật khẩu account
        private void btnRetype_Click(object sender, EventArgs e)
        {
            string userName = txbAccountUser.Text;

            ResetPass(userName);
        }
        //Button hiển thị datagidview account
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        #endregion
        #region ButtonFood
        //Textbox chứa id food (Lấy ra Category của food)
        private void txbIdFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbCategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbCategory.SelectedIndex = index;
                }
                else
                {
                    ;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        //Thêm món ăn
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int categoryID = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nudPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
                else
                {
                    ;
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }
        //Sửa món ăn
        private void btnRepair_Click(object sender, EventArgs e)
        {
            string name = txbNameFood.Text;
            int categoryID = (cbCategory.SelectedItem as Category).ID;
            float price = (float)nudPrice.Value;
            int id = Convert.ToInt32(txbIdFood.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
                else
                {
                    ;
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }
        //Xóa món ăn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdFood.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
                else
                {
                    ;
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        //Tìm món ăn theo tên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txbSearchFood.Text);
            foodList.DataSource = SearchFoodByName(txbSearchFood.Text);
        }
        //Hiện datagridview food
        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        //event thêm món
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        //event xóa món
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        // event sửa món
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


        #endregion
        #region ButtonCategory
        //Button thêm danh mục món ăn
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbNameCategory.Text;
            AddCategory(name);
        }
        //Button xóa danh mục món ăn
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdCategory.Text);
            DeteleCategory(id);
        }
        //Button hiển thị danh mục món ăn
        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();

        }
        //Button sửa danh mục món ăn
        private void btnRepairCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIdCategory.Text);
            string name = txbNameCategory.Text;
            EditCategory(id, name);
        }
        #endregion

        #endregion
    }
}
