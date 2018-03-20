namespace LoginApplication
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userEmailLabel;
            System.Windows.Forms.Label userFirstNameLabel;
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label userLastNameLabel;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label userPhoneNumberLabel;
            System.Windows.Forms.Label FindByEmailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userEmailTextBox = new System.Windows.Forms.TextBox();
            this.userFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userLastNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.FindByEmailGroupBox = new System.Windows.Forms.GroupBox();
            this.FindByEmailTextBox = new System.Windows.Forms.TextBox();
            this.FindByEmailButton = new System.Windows.Forms.Button();
            this.BrowseAllButton = new System.Windows.Forms.Button();
            userEmailLabel = new System.Windows.Forms.Label();
            userFirstNameLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            userLastNameLabel = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            userPhoneNumberLabel = new System.Windows.Forms.Label();
            FindByEmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.FindByEmailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userEmailLabel
            // 
            userEmailLabel.AutoSize = true;
            userEmailLabel.Location = new System.Drawing.Point(9, 228);
            userEmailLabel.Name = "userEmailLabel";
            userEmailLabel.Size = new System.Drawing.Size(46, 18);
            userEmailLabel.TabIndex = 1;
            userEmailLabel.Text = "Email:";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Location = new System.Drawing.Point(9, 94);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(84, 18);
            userFirstNameLabel.TabIndex = 3;
            userFirstNameLabel.Text = "First Name:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(9, 49);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(64, 18);
            userIdLabel.TabIndex = 5;
            userIdLabel.Text = "User ID:";
            // 
            // userLastNameLabel
            // 
            userLastNameLabel.AutoSize = true;
            userLastNameLabel.Location = new System.Drawing.Point(9, 139);
            userLastNameLabel.Name = "userLastNameLabel";
            userLastNameLabel.Size = new System.Drawing.Size(84, 18);
            userLastNameLabel.TabIndex = 7;
            userLastNameLabel.Text = "Last Name:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(9, 272);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(74, 18);
            userPasswordLabel.TabIndex = 9;
            userPasswordLabel.Text = "Password:";
            // 
            // userPhoneNumberLabel
            // 
            userPhoneNumberLabel.AutoSize = true;
            userPhoneNumberLabel.Location = new System.Drawing.Point(9, 183);
            userPhoneNumberLabel.Name = "userPhoneNumberLabel";
            userPhoneNumberLabel.Size = new System.Drawing.Size(110, 18);
            userPhoneNumberLabel.TabIndex = 11;
            userPhoneNumberLabel.Text = "Phone Number:";
            // 
            // FindByEmailLabel
            // 
            FindByEmailLabel.AutoSize = true;
            FindByEmailLabel.Location = new System.Drawing.Point(17, 42);
            FindByEmailLabel.Name = "FindByEmailLabel";
            FindByEmailLabel.Size = new System.Drawing.Size(46, 18);
            FindByEmailLabel.TabIndex = 14;
            FindByEmailLabel.Text = "Email:";
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.userBindingNavigator.TabIndex = 0;
            this.userBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LoginApplication.User);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Enabled = false;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
            // 
            // userEmailTextBox
            // 
            this.userEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserEmail", true));
            this.userEmailTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailTextBox.Location = new System.Drawing.Point(122, 221);
            this.userEmailTextBox.MaxLength = 128;
            this.userEmailTextBox.Name = "userEmailTextBox";
            this.userEmailTextBox.Size = new System.Drawing.Size(317, 30);
            this.userEmailTextBox.TabIndex = 5;
            // 
            // userFirstNameTextBox
            // 
            this.userFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserFirstName", true));
            this.userFirstNameTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFirstNameTextBox.Location = new System.Drawing.Point(122, 87);
            this.userFirstNameTextBox.MaxLength = 64;
            this.userFirstNameTextBox.Name = "userFirstNameTextBox";
            this.userFirstNameTextBox.Size = new System.Drawing.Size(317, 30);
            this.userFirstNameTextBox.TabIndex = 2;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserId", true));
            this.userIdTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(122, 42);
            this.userIdTextBox.MaxLength = 15;
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(317, 30);
            this.userIdTextBox.TabIndex = 1;
            // 
            // userLastNameTextBox
            // 
            this.userLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserLastName", true));
            this.userLastNameTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLastNameTextBox.Location = new System.Drawing.Point(122, 132);
            this.userLastNameTextBox.MaxLength = 64;
            this.userLastNameTextBox.Name = "userLastNameTextBox";
            this.userLastNameTextBox.Size = new System.Drawing.Size(317, 30);
            this.userLastNameTextBox.TabIndex = 3;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(122, 265);
            this.userPasswordTextBox.MaxLength = 32;
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(317, 30);
            this.userPasswordTextBox.TabIndex = 6;
            // 
            // userPhoneNumberTextBox
            // 
            this.userPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserPhoneNumber", true));
            this.userPhoneNumberTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhoneNumberTextBox.Location = new System.Drawing.Point(122, 176);
            this.userPhoneNumberTextBox.MaxLength = 10;
            this.userPhoneNumberTextBox.Name = "userPhoneNumberTextBox";
            this.userPhoneNumberTextBox.Size = new System.Drawing.Size(317, 30);
            this.userPhoneNumberTextBox.TabIndex = 4;
            // 
            // FindByEmailGroupBox
            // 
            this.FindByEmailGroupBox.Controls.Add(this.FindByEmailTextBox);
            this.FindByEmailGroupBox.Controls.Add(this.FindByEmailButton);
            this.FindByEmailGroupBox.Controls.Add(FindByEmailLabel);
            this.FindByEmailGroupBox.ForeColor = System.Drawing.Color.White;
            this.FindByEmailGroupBox.Location = new System.Drawing.Point(12, 310);
            this.FindByEmailGroupBox.Name = "FindByEmailGroupBox";
            this.FindByEmailGroupBox.Size = new System.Drawing.Size(427, 124);
            this.FindByEmailGroupBox.TabIndex = 13;
            this.FindByEmailGroupBox.TabStop = false;
            this.FindByEmailGroupBox.Text = " Find an User by Email ";
            // 
            // FindByEmailTextBox
            // 
            this.FindByEmailTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindByEmailTextBox.Location = new System.Drawing.Point(69, 35);
            this.FindByEmailTextBox.Name = "FindByEmailTextBox";
            this.FindByEmailTextBox.Size = new System.Drawing.Size(339, 30);
            this.FindByEmailTextBox.TabIndex = 8;
            // 
            // FindByEmailButton
            // 
            this.FindByEmailButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindByEmailButton.ForeColor = System.Drawing.Color.Black;
            this.FindByEmailButton.Location = new System.Drawing.Point(20, 76);
            this.FindByEmailButton.Name = "FindByEmailButton";
            this.FindByEmailButton.Size = new System.Drawing.Size(388, 33);
            this.FindByEmailButton.TabIndex = 9;
            this.FindByEmailButton.Text = "Find";
            this.FindByEmailButton.UseVisualStyleBackColor = true;
            this.FindByEmailButton.Click += new System.EventHandler(this.FindByEmailButton_Click);
            // 
            // BrowseAllButton
            // 
            this.BrowseAllButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrowseAllButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseAllButton.ForeColor = System.Drawing.Color.Black;
            this.BrowseAllButton.Location = new System.Drawing.Point(0, 449);
            this.BrowseAllButton.Name = "BrowseAllButton";
            this.BrowseAllButton.Size = new System.Drawing.Size(452, 35);
            this.BrowseAllButton.TabIndex = 7;
            this.BrowseAllButton.Text = "Browse All Entities";
            this.BrowseAllButton.UseVisualStyleBackColor = true;
            this.BrowseAllButton.Click += new System.EventHandler(this.BrowseAllButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(452, 484);
            this.Controls.Add(this.BrowseAllButton);
            this.Controls.Add(this.FindByEmailGroupBox);
            this.Controls.Add(userEmailLabel);
            this.Controls.Add(this.userEmailTextBox);
            this.Controls.Add(userFirstNameLabel);
            this.Controls.Add(this.userFirstNameTextBox);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(userLastNameLabel);
            this.Controls.Add(this.userLastNameTextBox);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(userPhoneNumberLabel);
            this.Controls.Add(this.userPhoneNumberTextBox);
            this.Controls.Add(this.userBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Navigation Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.FindByEmailGroupBox.ResumeLayout(false);
            this.FindByEmailGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox userEmailTextBox;
        private System.Windows.Forms.TextBox userFirstNameTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox userLastNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox userPhoneNumberTextBox;
        private System.Windows.Forms.GroupBox FindByEmailGroupBox;
        private System.Windows.Forms.Button FindByEmailButton;
        private System.Windows.Forms.Button BrowseAllButton;
        private System.Windows.Forms.TextBox FindByEmailTextBox;
    }
}