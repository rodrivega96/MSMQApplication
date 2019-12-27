namespace MessageQueue
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_queue = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.panelSend = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panelMsg.SuspendLayout();
            this.panelSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_queue
            // 
            this.btn_queue.Location = new System.Drawing.Point(309, 224);
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.Size = new System.Drawing.Size(106, 23);
            this.btn_queue.TabIndex = 0;
            this.btn_queue.Text = "Send to queue";
            this.btn_queue.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(267, 62);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Send E-Mail to: ";
            // 
            // panelMsg
            // 
            this.panelMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMsg.Controls.Add(this.txtMensaje);
            this.panelMsg.Controls.Add(this.label1);
            this.panelMsg.Controls.Add(this.btn_queue);
            this.panelMsg.Location = new System.Drawing.Point(12, 12);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(746, 259);
            this.panelMsg.TabIndex = 4;
            // 
            // panelSend
            // 
            this.panelSend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSend.Controls.Add(this.txt_email);
            this.panelSend.Controls.Add(this.btn_send);
            this.panelSend.Controls.Add(this.label2);
            this.panelSend.Controls.Add(this.btn_close);
            this.panelSend.Location = new System.Drawing.Point(12, 277);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(746, 98);
            this.panelSend.TabIndex = 5;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(384, 62);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(22, 28);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(704, 190);
            this.txtMensaje.TabIndex = 3;
            this.txtMensaje.Text = "";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(16, 36);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(710, 20);
            this.txt_email.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 387);
            this.Controls.Add(this.panelSend);
            this.Controls.Add(this.panelMsg);
            this.Name = "Form1";
            this.Text = "MSMQ Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_queue;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMsg;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_send;
    }
}

