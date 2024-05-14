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

        }
        void updateSize()
        {
            
            updateTotalPrice();

            if (rbsmall.Checked)
            {
                lbsize.Text = "Small";
                
                
            }

            if (rbmedium.Checked)
            {
                lbsize.Text = "Medium";
                
            }

            if (rblarge.Checked)
            {
                lbsize.Text = "Large";
                
            }
        }

        void updateCrust()
        {
            updateTotalPrice();

            if (rbthick.Checked)
            {
                lbcrust.Text = "Thick";
            }
            if (rbthin.Checked)
            {
                lbcrust.Text = "Thin";
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

            if(toppings == "")
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
            }

            if(rbtakeout.Checked)
            {
                lbwheretoeat.Text = "Take Away";
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

        void updateTotalPrice()
        {

            totalPrice = getSizePrice() + getCrustPrice() + getToppingsPrice();
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


    }
}
