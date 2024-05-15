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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
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
            this.lbdough = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.pbpizzatype = new System.Windows.Forms.PictureBox();
            this.bgpizzatype = new System.Windows.Forms.GroupBox();
            this.rbitalian = new System.Windows.Forms.RadioButton();
            this.rbamerican = new System.Windows.Forms.RadioButton();
            this.boxsize.SuspendLayout();
            this.boxcrust.SuspendLayout();
            this.boxwheretoeat.SuspendLayout();
            this.boxtoppings.SuspendLayout();
            this.boxsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpizzatype)).BeginInit();
            this.bgpizzatype.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // boxsize
            // 
            this.boxsize.BackColor = System.Drawing.SystemColors.Info;
            this.boxsize.Controls.Add(this.rblarge);
            this.boxsize.Controls.Add(this.rbmedium);
            this.boxsize.Controls.Add(this.rbsmall);
            this.boxsize.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxsize.Location = new System.Drawing.Point(34, 74);
            this.boxsize.Name = "boxsize";
            this.boxsize.Size = new System.Drawing.Size(155, 142);
            this.boxsize.TabIndex = 1;
            this.boxsize.TabStop = false;
            this.boxsize.Text = "Size";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.BackColor = System.Drawing.Color.Transparent;
            this.rblarge.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblarge.ForeColor = System.Drawing.Color.Black;
            this.rblarge.Location = new System.Drawing.Point(6, 97);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(103, 31);
            this.rblarge.TabIndex = 2;
            this.rblarge.Tag = "30";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = false;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.BackColor = System.Drawing.Color.Transparent;
            this.rbmedium.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmedium.ForeColor = System.Drawing.Color.Black;
            this.rbmedium.Location = new System.Drawing.Point(6, 63);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(125, 31);
            this.rbmedium.TabIndex = 1;
            this.rbmedium.Tag = "20";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = false;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbmedium_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.BackColor = System.Drawing.Color.Transparent;
            this.rbsmall.Checked = true;
            this.rbsmall.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsmall.ForeColor = System.Drawing.Color.Black;
            this.rbsmall.Location = new System.Drawing.Point(6, 30);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(99, 31);
            this.rbsmall.TabIndex = 0;
            this.rbsmall.TabStop = true;
            this.rbsmall.Tag = "10";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = false;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // boxcrust
            // 
            this.boxcrust.BackColor = System.Drawing.SystemColors.Info;
            this.boxcrust.Controls.Add(this.rbthick);
            this.boxcrust.Controls.Add(this.rbthin);
            this.boxcrust.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxcrust.Location = new System.Drawing.Point(197, 83);
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
            this.rbthick.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthick.Location = new System.Drawing.Point(6, 63);
            this.rbthick.Name = "rbthick";
            this.rbthick.Size = new System.Drawing.Size(99, 31);
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
            this.rbthin.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbthin.Location = new System.Drawing.Point(6, 30);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(85, 31);
            this.rbthin.TabIndex = 0;
            this.rbthin.Tag = "5";
            this.rbthin.Text = "Thin";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // boxwheretoeat
            // 
            this.boxwheretoeat.BackColor = System.Drawing.SystemColors.Info;
            this.boxwheretoeat.Controls.Add(this.rbtakeout);
            this.boxwheretoeat.Controls.Add(this.rbeatin);
            this.boxwheretoeat.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxwheretoeat.Location = new System.Drawing.Point(375, 83);
            this.boxwheretoeat.Name = "boxwheretoeat";
            this.boxwheretoeat.Size = new System.Drawing.Size(183, 119);
            this.boxwheretoeat.TabIndex = 3;
            this.boxwheretoeat.TabStop = false;
            this.boxwheretoeat.Text = "Where To Eat?";
            // 
            // rbtakeout
            // 
            this.rbtakeout.AutoSize = true;
            this.rbtakeout.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtakeout.Location = new System.Drawing.Point(6, 63);
            this.rbtakeout.Name = "rbtakeout";
            this.rbtakeout.Size = new System.Drawing.Size(171, 31);
            this.rbtakeout.TabIndex = 1;
            this.rbtakeout.Text = "Take Away";
            this.rbtakeout.UseVisualStyleBackColor = true;
            this.rbtakeout.CheckedChanged += new System.EventHandler(this.rbtakeout_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Checked = true;
            this.rbeatin.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbeatin.Location = new System.Drawing.Point(6, 30);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(113, 31);
            this.rbeatin.TabIndex = 0;
            this.rbeatin.TabStop = true;
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // boxtoppings
            // 
            this.boxtoppings.BackColor = System.Drawing.SystemColors.Info;
            this.boxtoppings.Controls.Add(this.chktomatos);
            this.boxtoppings.Controls.Add(this.chkextracheese);
            this.boxtoppings.Controls.Add(this.chkgreenpeppers);
            this.boxtoppings.Controls.Add(this.chkolives);
            this.boxtoppings.Controls.Add(this.chkonions);
            this.boxtoppings.Controls.Add(this.chkmushrooms);
            this.boxtoppings.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxtoppings.Location = new System.Drawing.Point(34, 219);
            this.boxtoppings.Name = "boxtoppings";
            this.boxtoppings.Size = new System.Drawing.Size(375, 119);
            this.boxtoppings.TabIndex = 3;
            this.boxtoppings.TabStop = false;
            this.boxtoppings.Text = "Toppings";
            // 
            // chktomatos
            // 
            this.chktomatos.AutoSize = true;
            this.chktomatos.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktomatos.ForeColor = System.Drawing.Color.Black;
            this.chktomatos.Location = new System.Drawing.Point(20, 77);
            this.chktomatos.Name = "chktomatos";
            this.chktomatos.Size = new System.Drawing.Size(137, 31);
            this.chktomatos.TabIndex = 5;
            this.chktomatos.Tag = "2";
            this.chktomatos.Text = "Tomatos";
            this.chktomatos.UseVisualStyleBackColor = true;
            this.chktomatos.CheckedChanged += new System.EventHandler(this.chktomatos_CheckedChanged);
            // 
            // chkextracheese
            // 
            this.chkextracheese.AutoSize = true;
            this.chkextracheese.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkextracheese.Location = new System.Drawing.Point(160, 54);
            this.chkextracheese.Name = "chkextracheese";
            this.chkextracheese.Size = new System.Drawing.Size(206, 31);
            this.chkextracheese.TabIndex = 4;
            this.chkextracheese.Tag = "2";
            this.chkextracheese.Text = "Extra Cheese";
            this.chkextracheese.UseVisualStyleBackColor = true;
            this.chkextracheese.CheckedChanged += new System.EventHandler(this.chkextracheese_CheckedChanged);
            // 
            // chkgreenpeppers
            // 
            this.chkgreenpeppers.AutoSize = true;
            this.chkgreenpeppers.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgreenpeppers.Location = new System.Drawing.Point(160, 77);
            this.chkgreenpeppers.Name = "chkgreenpeppers";
            this.chkgreenpeppers.Size = new System.Drawing.Size(203, 31);
            this.chkgreenpeppers.TabIndex = 3;
            this.chkgreenpeppers.Tag = "2";
            this.chkgreenpeppers.Text = "Green Pepper";
            this.chkgreenpeppers.UseVisualStyleBackColor = true;
            this.chkgreenpeppers.CheckedChanged += new System.EventHandler(this.chkgreenpeppers_CheckedChanged);
            // 
            // chkolives
            // 
            this.chkolives.AutoSize = true;
            this.chkolives.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkolives.Location = new System.Drawing.Point(20, 54);
            this.chkolives.Name = "chkolives";
            this.chkolives.Size = new System.Drawing.Size(114, 31);
            this.chkolives.TabIndex = 1;
            this.chkolives.Tag = "2";
            this.chkolives.Text = "Olives";
            this.chkolives.UseVisualStyleBackColor = true;
            this.chkolives.CheckedChanged += new System.EventHandler(this.chkolives_CheckedChanged);
            // 
            // chkonions
            // 
            this.chkonions.AutoSize = true;
            this.chkonions.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkonions.Location = new System.Drawing.Point(20, 31);
            this.chkonions.Name = "chkonions";
            this.chkonions.Size = new System.Drawing.Size(116, 31);
            this.chkonions.TabIndex = 0;
            this.chkonions.Tag = "2";
            this.chkonions.Text = "Onions";
            this.chkonions.UseVisualStyleBackColor = true;
            this.chkonions.CheckedChanged += new System.EventHandler(this.chkonions_CheckedChanged);
            // 
            // chkmushrooms
            // 
            this.chkmushrooms.AutoSize = true;
            this.chkmushrooms.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmushrooms.Location = new System.Drawing.Point(160, 31);
            this.chkmushrooms.Name = "chkmushrooms";
            this.chkmushrooms.Size = new System.Drawing.Size(171, 31);
            this.chkmushrooms.TabIndex = 2;
            this.chkmushrooms.Tag = "2";
            this.chkmushrooms.Text = "Mushrooms";
            this.chkmushrooms.UseVisualStyleBackColor = true;
            this.chkmushrooms.CheckedChanged += new System.EventHandler(this.chkmushrooms_CheckedChanged);
            // 
            // boxsummary
            // 
            this.boxsummary.BackColor = System.Drawing.Color.Black;
            this.boxsummary.Controls.Add(this.lbdough);
            this.boxsummary.Controls.Add(this.label7);
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
            this.boxsummary.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxsummary.ForeColor = System.Drawing.Color.Yellow;
            this.boxsummary.Location = new System.Drawing.Point(576, 83);
            this.boxsummary.Name = "boxsummary";
            this.boxsummary.Size = new System.Drawing.Size(212, 301);
            this.boxsummary.TabIndex = 4;
            this.boxsummary.TabStop = false;
            this.boxsummary.Text = "Order Summary";
            // 
            // lbdough
            // 
            this.lbdough.AutoSize = true;
            this.lbdough.Location = new System.Drawing.Point(68, 213);
            this.lbdough.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbdough.Name = "lbdough";
            this.lbdough.Size = new System.Drawing.Size(100, 27);
            this.lbdough.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dough";
            // 
            // lbtotalprice
            // 
            this.lbtotalprice.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbtotalprice.Location = new System.Drawing.Point(89, 263);
            this.lbtotalprice.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbtotalprice.Name = "lbtotalprice";
            this.lbtotalprice.Size = new System.Drawing.Size(100, 17);
            this.lbtotalprice.TabIndex = 9;
            // 
            // lbcrust
            // 
            this.lbcrust.AutoSize = true;
            this.lbcrust.Location = new System.Drawing.Point(68, 68);
            this.lbcrust.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbcrust.Name = "lbcrust";
            this.lbcrust.Size = new System.Drawing.Size(100, 27);
            this.lbcrust.TabIndex = 8;
            // 
            // lbtoppings
            // 
            this.lbtoppings.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtoppings.Location = new System.Drawing.Point(6, 125);
            this.lbtoppings.MinimumSize = new System.Drawing.Size(170, 30);
            this.lbtoppings.Name = "lbtoppings";
            this.lbtoppings.Size = new System.Drawing.Size(200, 30);
            this.lbtoppings.TabIndex = 7;
            this.lbtoppings.Text = "No Toppings";
            // 
            // lbwheretoeat
            // 
            this.lbwheretoeat.AutoSize = true;
            this.lbwheretoeat.Location = new System.Drawing.Point(112, 166);
            this.lbwheretoeat.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbwheretoeat.Name = "lbwheretoeat";
            this.lbwheretoeat.Size = new System.Drawing.Size(100, 27);
            this.lbwheretoeat.TabIndex = 6;
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbsize.Location = new System.Drawing.Point(55, 35);
            this.lbsize.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(100, 27);
            this.lbsize.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Where To Eat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Crust:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.SystemColors.Info;
            this.btnorder.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(550, 390);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(113, 39);
            this.btnorder.TabIndex = 5;
            this.btnorder.Text = "Order Pizza";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.Info;
            this.btnreset.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(669, 390);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(113, 39);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // pbpizzatype
            // 
            this.pbpizzatype.Image = global::Make_your_Pizza.Properties.Resources.american_pizza;
            this.pbpizzatype.Location = new System.Drawing.Point(171, 366);
            this.pbpizzatype.Name = "pbpizzatype";
            this.pbpizzatype.Size = new System.Drawing.Size(91, 72);
            this.pbpizzatype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbpizzatype.TabIndex = 7;
            this.pbpizzatype.TabStop = false;
            // 
            // bgpizzatype
            // 
            this.bgpizzatype.BackColor = System.Drawing.SystemColors.Info;
            this.bgpizzatype.Controls.Add(this.rbitalian);
            this.bgpizzatype.Controls.Add(this.rbamerican);
            this.bgpizzatype.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgpizzatype.Location = new System.Drawing.Point(279, 346);
            this.bgpizzatype.Name = "bgpizzatype";
            this.bgpizzatype.Size = new System.Drawing.Size(173, 92);
            this.bgpizzatype.TabIndex = 4;
            this.bgpizzatype.TabStop = false;
            this.bgpizzatype.Text = "Dough";
            // 
            // rbitalian
            // 
            this.rbitalian.AutoSize = true;
            this.rbitalian.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbitalian.Location = new System.Drawing.Point(6, 63);
            this.rbitalian.Name = "rbitalian";
            this.rbitalian.Size = new System.Drawing.Size(119, 31);
            this.rbitalian.TabIndex = 1;
            this.rbitalian.Tag = "7";
            this.rbitalian.Text = "Italian";
            this.rbitalian.UseVisualStyleBackColor = true;
            this.rbitalian.CheckedChanged += new System.EventHandler(this.rbitalian_CheckedChanged);
            // 
            // rbamerican
            // 
            this.rbamerican.AutoSize = true;
            this.rbamerican.Checked = true;
            this.rbamerican.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbamerican.Location = new System.Drawing.Point(6, 26);
            this.rbamerican.Name = "rbamerican";
            this.rbamerican.Size = new System.Drawing.Size(146, 31);
            this.rbamerican.TabIndex = 0;
            this.rbamerican.TabStop = true;
            this.rbamerican.Tag = "5";
            this.rbamerican.Text = "American";
            this.rbamerican.UseVisualStyleBackColor = true;
            this.rbamerican.CheckedChanged += new System.EventHandler(this.rbamerican_CheckedChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bgpizzatype);
            this.Controls.Add(this.pbpizzatype);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbpizzatype)).EndInit();
            this.bgpizzatype.ResumeLayout(false);
            this.bgpizzatype.PerformLayout();
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
        private System.Windows.Forms.PictureBox pbpizzatype;
        private System.Windows.Forms.GroupBox bgpizzatype;
        private System.Windows.Forms.RadioButton rbitalian;
        private System.Windows.Forms.RadioButton rbamerican;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbdough;
    }
}