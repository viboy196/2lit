namespace TTCNTT_NguyenVanDan_16151405
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartNode = new System.Windows.Forms.NumericUpDown();
            this.EndNode = new System.Windows.Forms.NumericUpDown();
            this.NumEdge = new System.Windows.Forms.NumericUpDown();
            this.Numnode = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numnode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 735);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1160, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nhập số cạnh";
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(1163, 194);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(75, 23);
            this.random.TabIndex = 6;
            this.random.Text = "random";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1161, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Djkstra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1160, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "điểm bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1158, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "điểm kết thúc";
            // 
            // StartNode
            // 
            this.StartNode.Location = new System.Drawing.Point(1163, 258);
            this.StartNode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNode.Name = "StartNode";
            this.StartNode.Size = new System.Drawing.Size(75, 20);
            this.StartNode.TabIndex = 12;
            this.StartNode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndNode
            // 
            this.EndNode.Location = new System.Drawing.Point(1161, 319);
            this.EndNode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNode.Name = "EndNode";
            this.EndNode.Size = new System.Drawing.Size(77, 20);
            this.EndNode.TabIndex = 13;
            this.EndNode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumEdge
            // 
            this.NumEdge.Location = new System.Drawing.Point(1163, 137);
            this.NumEdge.Name = "NumEdge";
            this.NumEdge.Size = new System.Drawing.Size(75, 20);
            this.NumEdge.TabIndex = 14;
            // 
            // Numnode
            // 
            this.Numnode.Location = new System.Drawing.Point(1163, 82);
            this.Numnode.Name = "Numnode";
            this.Numnode.Size = new System.Drawing.Size(75, 20);
            this.Numnode.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1157, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "căn chỉnh điểm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1160, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "nhập số điểm";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1163, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Astar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 759);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Numnode);
            this.Controls.Add(this.NumEdge);
            this.Controls.Add(this.EndNode);
            this.Controls.Add(this.StartNode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.random);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Tìm Đường ĐI Ngắn Nhất";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numnode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown StartNode;
        private System.Windows.Forms.NumericUpDown EndNode;
        private System.Windows.Forms.NumericUpDown NumEdge;
        private System.Windows.Forms.NumericUpDown Numnode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

