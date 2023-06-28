
namespace MelodyMusic
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.stu_details = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.Button();
            this.payments = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stu_details
            // 
            this.stu_details.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stu_details.Location = new System.Drawing.Point(77, 113);
            this.stu_details.Name = "stu_details";
            this.stu_details.Size = new System.Drawing.Size(260, 74);
            this.stu_details.TabIndex = 0;
            this.stu_details.Text = "Student Details";
            this.stu_details.UseVisualStyleBackColor = true;
            this.stu_details.Click += new System.EventHandler(this.stu_details_Click);
            // 
            // course
            // 
            this.course.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.course.Location = new System.Drawing.Point(77, 266);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(260, 74);
            this.course.TabIndex = 1;
            this.course.Text = "Course";
            this.course.UseVisualStyleBackColor = true;
            this.course.Click += new System.EventHandler(this.course_Click);
            // 
            // payments
            // 
            this.payments.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payments.Location = new System.Drawing.Point(77, 418);
            this.payments.Name = "payments";
            this.payments.Size = new System.Drawing.Size(260, 74);
            this.payments.TabIndex = 2;
            this.payments.Text = "Payments";
            this.payments.UseVisualStyleBackColor = true;
            this.payments.Click += new System.EventHandler(this.payments_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(847, 567);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 53);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.payments);
            this.Controls.Add(this.course);
            this.Controls.Add(this.stu_details);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stu_details;
        private System.Windows.Forms.Button course;
        private System.Windows.Forms.Button payments;
        private System.Windows.Forms.Button exit;
    }
}