namespace Make_your_Pizza
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.boxsize = new System.Windows.Forms.GroupBox();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmedium = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.boxcrust = new System.Windows.Forms.GroupBox();
            this.rbthick = new System.Windows.Forms.RadioButton();
            this.rbthin = new System.Windows.Forms.RadioButton();
            this.boxwheretoeat = new System.Windows.Forms.GroupBox();
            this.rbtakeout = new System.Windows.Forms.RadioButton();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.boxtoppings = new System.Windows.Forms.GroupBox();
            this.chktomatos = new System.Windows.Forms.CheckBox();
            this.chkextracheese = new System.Windows.Forms.CheckBox();
            this.chkgreenpeppers = new System.Windows.Forms.CheckBox();
            this.chkolives = new System.Windows.Forms.CheckBox();
            this.chkonions = new System.Windows.Forms.CheckBox();
            this.chkmushrooms = new System.Windows.Forms.CheckBox();
            this.boxsummary = new System.Windows.Forms.GroupBox();
            this.lbtotalprice = new System.Windows.Forms.Label();
            this.lbcrust = new System.Windows.Forms.Label();
            this.lbtoppings = new System.Windows.Forms.Label();
            this.lbwheretoeat = new System.Windows.Forms.Label();
            this.lbsize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.boxsize.SuspendLayout();
            this.boxcrust.SuspendLayout();
            this.boxwheretoeat.SuspendLayout();
            this.boxtoppings.SuspendLayout();
            this.boxsummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // boxsize
            // 
            this.boxsize.Controls.Add(this.rblarge);
            this.boxsize.Controls.Add(this.rbmedium);
            this.boxsize.Controls.Add(this.rbsmall);
            this.boxsize.Location = new System.Drawing.Point(55, 106);
            this.boxsize.Name = "boxsize";
            this.boxsize.Size = new System.Drawing.Size(155, 119);
            this.boxsize.TabIndex = 1;
            this.boxsize.TabStop = false;
            this.boxsize.Text = "Size";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Location = new System.Drawing.Point(6, 96);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(52, 17);
            this.rblarge.TabIndex = 2;
            this.rblarge.TabStop = true;
            this.rblarge.Tag = "30";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.Location = new System.Drawing.Point(6, 63);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(62, 17);
            this.rbmedium.TabIndex = 1;
            this.rbmedium.TabStop = true;
            this.rbmedium.Tag = "20";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = true;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbmedium_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Checked = true;
            this.rbsmall.Location = new System.Drawing.Point(6, 30);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(50, 17);
            this.rbsmall.TabIndex = 0;
            this.rbsmall.TabStop = true;
            this.rbsmall.Tag = "10";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // boxcrust
            // 
            this.boxcrust.Controls.Add(this.rbthick);
            this.boxcrust.Controls.Add(this.rbthin);
            this.boxcrust.Location = new System.Drawing.Point(267, 106);
            this.boxcrust.Name = "boxcrust";
            this.boxcrust.Size = new System.Drawing.Size(155, 119);
            this.boxcrust.TabIndex = 3;
            this.boxcrust.TabStop = false;
            this.boxcrust.Text = "Crust";
            // 
            // rbthick
            // 
            this.rbthick.AutoSize = true;
            this.rbthick.Checked = true;
            this.rbthick.Location = new System.Drawing.Point(6, 63);
            this.rbthick.Name = "rbthick";
            this.rbthick.Size = new System.Drawing.Size(52, 17);
            this.rbthick.TabIndex = 1;
            this.rbthick.TabStop = true;
            this.rbthick.Tag = "0";
            this.rbthick.Text = "Thick";
            this.rbthick.UseVisualStyleBackColor = true;
            this.rbthick.CheckedChanged += new System.EventHandler(this.rbthick_CheckedChanged);
            // 
            // rbthin
            // 
            this.rbthin.AutoSize = true;
            this.rbthin.Location = new System.Drawing.Point(6, 30);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(46, 17);
            this.rbthin.TabIndex = 0;
            this.rbthin.TabStop = true;
            this.rbthin.Tag = "5";
            this.rbthin.Text = "Thin";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // boxwheretoeat
            // 
            this.boxwheretoeat.Controls.Add(this.rbtakeout);
            this.boxwheretoeat.Controls.Add(this.rbeatin);
            this.boxwheretoeat.Location = new System.Drawing.Point(55, 242);
            this.boxwheretoeat.Name = "boxwheretoeat";
            this.boxwheretoeat.Size = new System.Drawing.Size(155, 119);
            this.boxwheretoeat.TabIndex = 3;
            this.boxwheretoeat.TabStop = false;
            this.boxwheretoeat.Text = "Where To Eat?";
            // 
            // rbtakeout
            // 
            this.rbtakeout.AutoSize = true;
            this.rbtakeout.Location = new System.Drawing.Point(6, 63);
            this.rbtakeout.Name = "rbtakeout";
            this.rbtakeout.Size = new System.Drawing.Size(79, 17);
            this.rbtakeout.TabIndex = 1;
            this.rbtakeout.TabStop = true;
            this.rbtakeout.Text = "Take Away";
            this.rbtakeout.UseVisualStyleBackColor = true;
            this.rbtakeout.CheckedChanged += new System.EventHandler(this.rbtakeout_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Checked = true;
            this.rbeatin.Location = new System.Drawing.Point(6, 30);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(53, 17);
            this.rbeatin.TabIndex = 0;
            this.rbeatin.TabStop = true;
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // boxtoppings
            // 
            this.boxtoppings.Controls.Add(this.chktomatos);
            this.boxtoppings.Controls.Add(this.chkextracheese);
            this.boxtoppings.Controls.Add(this.chkgreenpeppers);
            this.boxtoppings.Controls.Add(this.chkolives);
            this.boxtoppings.Controls.Add(this.chkonions);
            this.boxtoppings.Controls.Add(this.chkmushrooms);
            this.boxtoppings.Location = new System.Drawing.Point(257, 242);
            this.boxtoppings.Name = "boxtoppings";
            this.boxtoppings.Size = new System.Drawing.Size(231, 119);
            this.boxtoppings.TabIndex = 3;
            this.boxtoppings.TabStop = false;
            this.boxtoppings.Text = "Toppings";
            // 
            // chktomatos
            // 
            this.chktomatos.AutoSize = true;
            this.chktomatos.Location = new System.Drawing.Point(20, 77);
            this.chktomatos.Name = "chktomatos";
            this.chktomatos.Size = new System.Drawing.Size(67, 17);
            this.chktomatos.TabIndex = 5;
            this.chktomatos.Tag = "2";
            this.chktomatos.Text = "Tomatos";
            this.chktomatos.UseVisualStyleBackColor = true;
            this.chktomatos.CheckedChanged += new System.EventHandler(this.chktomatos_CheckedChanged);
            // 
            // chkextracheese
            // 
            this.chkextracheese.AutoSize = true;
            this.chkextracheese.Location = new System.Drawing.Point(106, 53);
            this.chkextracheese.Name = "chkextracheese";
            this.chkextracheese.Size = new System.Drawing.Size(89, 17);
            this.chkextracheese.TabIndex = 4;
            this.chkextracheese.Tag = "2";
            this.chkextracheese.Text = "Extra Cheese";
            this.chkextracheese.UseVisualStyleBackColor = true;
            this.chkextracheese.CheckedChanged += new System.EventHandler(this.chkextracheese_CheckedChanged);
            // 
            // chkgreenpeppers
            // 
            this.chkgreenpeppers.AutoSize = true;
            this.chkgreenpeppers.Location = new System.Drawing.Point(106, 77);
            this.chkgreenpeppers.Name = "chkgreenpeppers";
            this.chkgreenpeppers.Size = new System.Drawing.Size(92, 17);
            this.chkgreenpeppers.TabIndex = 3;
            this.chkgreenpeppers.Tag = "2";
            this.chkgreenpeppers.Text = "Green Pepper";
            this.chkgreenpeppers.UseVisualStyleBackColor = true;
            this.chkgreenpeppers.CheckedChanged += new System.EventHandler(this.chkgreenpeppers_CheckedChanged);
            // 
            // chkolives
            // 
            this.chkolives.AutoSize = true;
            this.chkolives.Location = new System.Drawing.Point(20, 54);
            this.chkolives.Name = "chkolives";
            this.chkolives.Size = new System.Drawing.Size(55, 17);
            this.chkolives.TabIndex = 1;
            this.chkolives.Tag = "2";
            this.chkolives.Text = "Olives";
            this.chkolives.UseVisualStyleBackColor = true;
            this.chkolives.CheckedChanged += new System.EventHandler(this.chkolives_CheckedChanged);
            // 
            // chkonions
            // 
            this.chkonions.AutoSize = true;
            this.chkonions.Location = new System.Drawing.Point(20, 31);
            this.chkonions.Name = "chkonions";
            this.chkonions.Size = new System.Drawing.Size(59, 17);
            this.chkonions.TabIndex = 0;
            this.chkonions.Tag = "2";
            this.chkonions.Text = "Onions";
            this.chkonions.UseVisualStyleBackColor = true;
            this.chkonions.CheckedChanged += new System.EventHandler(this.chkonions_CheckedChanged);
            // 
            // chkmushrooms
            // 
            this.chkmushrooms.AutoSize = true;
            this.chkmushrooms.Location = new System.Drawing.Point(106, 30);
            this.chkmushrooms.Name = "chkmushrooms";
            this.chkmushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkmushrooms.TabIndex = 2;
            this.chkmushrooms.Tag = "2";
            this.chkmushrooms.Text = "Mushrooms";
            this.chkmushrooms.UseVisualStyleBackColor = true;
            this.chkmushrooms.CheckedChanged += new System.EventHandler(this.chkmushrooms_CheckedChanged);
            // 
            // boxsummary
            // 
            this.boxsummary.Controls.Add(this.lbtotalprice);
            this.boxsummary.Controls.Add(this.lbcrust);
            this.boxsummary.Controls.Add(this.lbtoppings);
            this.boxsummary.Controls.Add(this.lbwheretoeat);
            this.boxsummary.Controls.Add(this.lbsize);
            this.boxsummary.Controls.Add(this.label6);
            this.boxsummary.Controls.Add(this.label5);
            this.boxsummary.Controls.Add(this.label4);
            this.boxsummary.Controls.Add(this.label3);
            this.boxsummary.Controls.Add(this.label2);
            this.boxsummary.Location = new System.Drawing.Point(527, 106);
            this.boxsummary.Name = "boxsummary";
            this.boxsummary.Size = new System.Drawing.Size(212, 255);
            this.boxsummary.TabIndex = 4;
            this.boxsummary.TabStop = false;
            this.boxsummary.Text = "Order Summary";
            // 
            // lbtotalprice
            // 
            this.lbtotalprice.AutoSize = true;
            this.lbtotalprice.Location = new System.Drawing.Point(78, 203);
            this.lbtotalprice.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbtotalprice.Name = "lbtotalprice";
            this.lbtotalprice.Size = new System.Drawing.Size(100, 13);
            this.lbtotalprice.TabIndex = 9;
            // 
            // lbcrust
            // 
            this.lbcrust.AutoSize = true;
            this.lbcrust.Location = new System.Drawing.Point(55, 68);
            this.lbcrust.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbcrust.Name = "lbcrust";
            this.lbcrust.Size = new System.Drawing.Size(100, 13);
            this.lbcrust.TabIndex = 8;
            // 
            // lbtoppings
            // 
            this.lbtoppings.Location = new System.Drawing.Point(11, 122);
            this.lbtoppings.MinimumSize = new System.Drawing.Size(170, 30);
            this.lbtoppings.Name = "lbtoppings";
            this.lbtoppings.Size = new System.Drawing.Size(200, 30);
            this.lbtoppings.TabIndex = 7;
            this.lbtoppings.Text = "No Toppings";
            // 
            // lbwheretoeat
            // 
            this.lbwheretoeat.AutoSize = true;
            this.lbwheretoeat.Location = new System.Drawing.Point(89, 167);
            this.lbwheretoeat.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbwheretoeat.Name = "lbwheretoeat";
            this.lbwheretoeat.Size = new System.Drawing.Size(100, 13);
            this.lbwheretoeat.TabIndex = 6;
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Location = new System.Drawing.Point(55, 35);
            this.lbsize.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(100, 13);
            this.lbsize.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Where To Eat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Crust:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(256, 399);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(113, 39);
            this.btnorder.TabIndex = 5;
            this.btnorder.Text = "Order Pizza";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(375, 399);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(113, 39);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.boxsummary);
            this.Controls.Add(this.boxtoppings);
            this.Controls.Add(this.boxwheretoeat);
            this.Controls.Add(this.boxcrust);
            this.Controls.Add(this.boxsize);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.boxsize.ResumeLayout(false);
            this.boxsize.PerformLayout();
            this.boxcrust.ResumeLayout(false);
            this.boxcrust.PerformLayout();
            this.boxwheretoeat.ResumeLayout(false);
            this.boxwheretoeat.PerformLayout();
            this.boxtoppings.ResumeLayout(false);
            this.boxtoppings.PerformLayout();
            this.boxsummary.ResumeLayout(false);
            this.boxsummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox boxsize;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmedium;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.GroupBox boxcrust;
        private System.Windows.Forms.RadioButton rbthick;
        private System.Windows.Forms.RadioButton rbthin;
        private System.Windows.Forms.GroupBox boxwheretoeat;
        private System.Windows.Forms.RadioButton rbtakeout;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.GroupBox boxtoppings;
        private System.Windows.Forms.CheckBox chktomatos;
        private System.Windows.Forms.CheckBox chkextracheese;
        private System.Windows.Forms.CheckBox chkgreenpeppers;
        private System.Windows.Forms.CheckBox chkolives;
        private System.Windows.Forms.CheckBox chkonions;
        private System.Windows.Forms.CheckBox chkmushrooms;
        private System.Windows.Forms.GroupBox boxsummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label lbsize;
        private System.Windows.Forms.Label lbtotalprice;
        private System.Windows.Forms.Label lbcrust;
        private System.Windows.Forms.Label lbtoppings;
        private System.Windows.Forms.Label lbwheretoeat;
    }
}