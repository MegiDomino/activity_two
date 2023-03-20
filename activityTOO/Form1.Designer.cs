namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listahan = new System.Windows.Forms.ListBox();
            this.wishList = new System.Windows.Forms.Label();
            this.butang = new System.Windows.Forms.Button();
            this.tangtang = new System.Windows.Forms.Button();
            this.ihap = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.selectionOut = new System.Windows.Forms.TextBox();
            this.countOut = new System.Windows.Forms.TextBox();
            this.sort = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listahan
            // 
            this.listahan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listahan.FormattingEnabled = true;
            this.listahan.Location = new System.Drawing.Point(42, 81);
            this.listahan.Name = "listahan";
            this.listahan.Size = new System.Drawing.Size(246, 238);
            this.listahan.TabIndex = 0;
            this.listahan.SelectedIndexChanged += new System.EventHandler(this.listahan_SelectedIndexChanged);
            // 
            // wishList
            // 
            this.wishList.AutoSize = true;
            this.wishList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishList.Location = new System.Drawing.Point(35, 41);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(128, 37);
            this.wishList.TabIndex = 1;
            this.wishList.Text = "Wishlist";
            this.wishList.Click += new System.EventHandler(this.label1_Click);
            // 
            // butang
            // 
            this.butang.Location = new System.Drawing.Point(323, 81);
            this.butang.Name = "butang";
            this.butang.Size = new System.Drawing.Size(75, 23);
            this.butang.TabIndex = 2;
            this.butang.Text = "Fill";
            this.butang.UseVisualStyleBackColor = true;
            this.butang.Click += new System.EventHandler(this.butang_Click);
            // 
            // tangtang
            // 
            this.tangtang.Location = new System.Drawing.Point(323, 174);
            this.tangtang.Name = "tangtang";
            this.tangtang.Size = new System.Drawing.Size(75, 23);
            this.tangtang.TabIndex = 3;
            this.tangtang.Text = "Clear";
            this.tangtang.UseVisualStyleBackColor = true;
            this.tangtang.Click += new System.EventHandler(this.tangtang_Click);
            // 
            // ihap
            // 
            this.ihap.Location = new System.Drawing.Point(323, 216);
            this.ihap.Name = "ihap";
            this.ihap.Size = new System.Drawing.Size(75, 23);
            this.ihap.TabIndex = 4;
            this.ihap.Text = "Count";
            this.ihap.UseVisualStyleBackColor = true;
            this.ihap.Click += new System.EventHandler(this.ihap_Click);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection.Location = new System.Drawing.Point(38, 337);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(79, 20);
            this.selection.TabIndex = 5;
            this.selection.Text = "Selection:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(38, 396);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(56, 20);
            this.count.TabIndex = 6;
            this.count.Text = "Count:";
            // 
            // selectionOut
            // 
            this.selectionOut.Location = new System.Drawing.Point(123, 339);
            this.selectionOut.Name = "selectionOut";
            this.selectionOut.Size = new System.Drawing.Size(165, 20);
            this.selectionOut.TabIndex = 7;
            this.selectionOut.TextChanged += new System.EventHandler(this.selectionOut_TextChanged);
            // 
            // countOut
            // 
            this.countOut.Location = new System.Drawing.Point(123, 396);
            this.countOut.Name = "countOut";
            this.countOut.Size = new System.Drawing.Size(165, 20);
            this.countOut.TabIndex = 8;
            this.countOut.TextChanged += new System.EventHandler(this.countOut_TextChanged);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(323, 128);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 9;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(323, 267);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 10;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 487);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.countOut);
            this.Controls.Add(this.selectionOut);
            this.Controls.Add(this.count);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.ihap);
            this.Controls.Add(this.tangtang);
            this.Controls.Add(this.butang);
            this.Controls.Add(this.wishList);
            this.Controls.Add(this.listahan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listahan;
        private System.Windows.Forms.Label wishList;
        private System.Windows.Forms.Button butang;
        private System.Windows.Forms.Button tangtang;
        private System.Windows.Forms.Button ihap;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox selectionOut;
        private System.Windows.Forms.TextBox countOut;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button closebtn;
    }
}

