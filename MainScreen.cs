using Make_your_Pizza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_your_Pizza
{
    public partial class MainScreen : Form
    {

        
        public MainScreen()
        {
            InitializeComponent();
        }

        float totalPrice = 0;

        void resetForm()
        {

            boxsize.Enabled = true;
            boxtoppings.Enabled = true;
            boxcrust.Enabled = true;
            boxwheretoeat.Enabled = true;

            rbsmall.Checked = true;

            chkextracheese.Checked = false;
            chkonions.Checked = false;
            chkmushrooms.Checked = false;
            chkolives.Checked = false;
            chktomatos.Checked = false;
            chkgreenpeppers.Checked = false;
          
            rbthick.Checked = true;
            rbtakeout.Checked = true;
            btnorder.Enabled = true;

            rbamerican.Checked = true;
            rbitalian.Checked = false;
            bgpizzatype.Enabled = true;

        }

        void updateSize()
        {
            
            updateTotalPrice();

            if (rbsmall.Checked)
            {
                lbsize.Text = "Small";
                return;
                
                
            }

            if (rbmedium.Checked)
            {
                lbsize.Text = "Medium";
                return;
                
            }

            if (rblarge.Checked)
            {
                lbsize.Text = "Large";
                return;
                
            }
        }

        void updateCrust()
        {
            updateTotalPrice();

            if (rbthick.Checked)
            {
                lbcrust.Text = "Thick";
                return;
            }
            if (rbthin.Checked)
            {
                lbcrust.Text = "Thin";
                return;
            }
        }

        void updateToppings()
        {
            string toppings = "";
            updateTotalPrice();

            if (chkextracheese.Checked)
            {
                toppings = "Extra Cheese";
            }

            if (chkgreenpeppers.Checked)
            {
                toppings += ", Green Peppers";
            }

            if (chkmushrooms.Checked)
            {
                toppings += ", Mushrooms";
            }

            if (chkolives.Checked)
            {
                toppings += ", Olives";
            }

            if (chkonions.Checked)
            {
                toppings += ", Onions";
            }

            if (chktomatos.Checked)
            {
                toppings += ", Tomatos";
            }

            if (toppings.StartsWith(","))
            {
                toppings = toppings.Substring(1, toppings.Length - 1).Trim();
            }

            if (toppings == "")
            {
                toppings = "No Toppings";
                
            }

            lbtoppings.Text = toppings;
        }

        void updateWhereToEat()
        {
            if (rbeatin.Checked)
            {
                lbwheretoeat.Text = "Eat In";
                return;
            }

            if(rbtakeout.Checked)
            {
                lbwheretoeat.Text = "Take Away";
                return;
            }
        }

        float getSizePrice()
        {
            if (rbsmall.Checked)

                return Convert.ToSingle(rbsmall.Tag);

            else if (rbmedium.Checked)

                return Convert.ToSingle(rbmedium.Tag);

            else
                return Convert.ToSingle(rblarge.Tag);
        }

        float getCrustPrice()
        {
            if (rbthick.Checked)
            {
                return Convert.ToSingle(rbthick.Tag);
            }
            else
            {
                return Convert.ToSingle(rbthin.Tag);
            }
        }

        float getToppingsPrice()
        {
            float toppingPrice = 0;

            if (chkextracheese.Checked)
            {
                toppingPrice += Convert.ToSingle(chkextracheese.Tag);
            }

            if (chkgreenpeppers.Checked)
            {
                toppingPrice += Convert.ToSingle(chkgreenpeppers.Tag);
            }

            if (chkmushrooms.Checked)
            {
                toppingPrice += Convert.ToSingle(chkmushrooms.Tag);
            }

            if (chkolives.Checked)
            {
                toppingPrice += Convert.ToSingle(chkolives.Tag);
            }

            if (chkonions.Checked)
            {
                toppingPrice += Convert.ToSingle(chkonions.Tag);
            }

            if (chktomatos.Checked)
            {
                toppingPrice += Convert.ToSingle(chktomatos.Tag);
            }

            return toppingPrice;
        }

        float getDoughPrice()
        {
            if (rbamerican.Checked)
            {
                return Convert.ToSingle(rbamerican.Tag);
            }

            else
            {
                return Convert.ToSingle(rbitalian.Tag);
            }

        }

        float calcTotalPrice()
        {
            return getSizePrice() + getCrustPrice() + getToppingsPrice() + getDoughPrice();
        }

        void updateTotalPrice()
        {

            totalPrice = calcTotalPrice();
            lbtotalprice.Text = totalPrice.ToString() + "$";
        }

        void updateOrderSummary()
        {

            updateSize();
            updateCrust();
            updateToppings();
            updateWhereToEat();
            updateTotalPrice();
        }

        void updatedoughimage()
        {
            if (rbamerican.Checked)
            {
                pbpizzatype.Image = Resources.american_pizza;
                return;
            }

            if (rbitalian.Checked)
            {
                pbpizzatype.Image = Resources.italian_pizza;
                return;
            }


        }

        void updateDoughType()
        {
            updateTotalPrice();
            updatedoughimage();

            if(rbamerican.Checked)
            {
                lbdough.Text = "American";
                return;
            }

            if (rbitalian.Checked)
            {
                lbdough.Text = "Italian";
                return;
            }

        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rbthick_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rbmedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void chkonions_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkolives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chktomatos_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkmushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkextracheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkgreenpeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void rbtakeout_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                boxcrust.Enabled = false;
                boxsize.Enabled = false;
                boxtoppings.Enabled = false;
                boxwheretoeat.Enabled = false;
                btnorder.Enabled = false;
                bgpizzatype.Enabled = false;
            }

            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            updateOrderSummary();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void rbamerican_CheckedChanged(object sender, EventArgs e)
        {
            updateDoughType();
            
        }

        private void rbitalian_CheckedChanged(object sender, EventArgs e)
        {
            updateDoughType();
        }
    }
}
