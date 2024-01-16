namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int result = 0;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
              
            buttonIncr = new Button();
            buttonDecr = new Button();
            buttonPosition = new Button();
            labelResult = new Label();

        SuspendLayout();
            // 
            // buttonIncr
            // 
            buttonIncr.Location = new Point(10, 0);
            buttonIncr.Margin = new Padding(1, 1, 1, 1);
            buttonIncr.Name = "buttonIncr";
            buttonIncr.Size = new Size(40, 40);
            buttonIncr.TabIndex = 1;
            buttonIncr.Text = "+";
            buttonIncr.UseVisualStyleBackColor = true;
            buttonIncr.Click += buttonIncr_Click;
            // 
            // buttonDecr
            // 
            buttonDecr.Location = new Point(60, 0);
            buttonDecr.Margin = new Padding(1, 1, 1, 1);
            buttonDecr.Name = "buttonDecr";
            buttonDecr.Size = new Size(40, 40);
            buttonDecr.TabIndex = 2;
            buttonDecr.Text = "-";
            buttonDecr.UseVisualStyleBackColor = true;
            buttonDecr.Click += buttonDecr_Click;
            // 
            // buttonPosition
            // 
            buttonPosition.Location = new Point(10, 100);
            buttonPosition.Margin = new Padding(1, 1, 1, 1);
            buttonPosition.Name = "buttonPosition";
            buttonPosition.Size = new Size(100, 40);
            buttonPosition.TabIndex = 3;
            buttonPosition.Text = "position";
            buttonPosition.UseVisualStyleBackColor = true;
            buttonPosition.Click += buttonPosition_Click;
            // 
            // Label
            // 

            labelResult.AutoSize = true;
            labelResult.Location = new Point(50, 60);
            labelResult.Name = "labelResult";
            labelResult.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.ForeColor = Color.White;
            labelResult.Size = new Size(40, 40);
            labelResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(50, 50);
            Controls.Add(buttonIncr);
            Controls.Add(buttonDecr);
            Controls.Add(buttonPosition);
            Controls.Add(labelResult);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "IncrDecr";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }



        #endregion

        private Button buttonIncr;
        private Button buttonDecr;
        private Button buttonPosition;
        private Label labelResult;

    }



}