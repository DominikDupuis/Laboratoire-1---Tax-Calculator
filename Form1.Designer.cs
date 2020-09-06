namespace Laboratoire_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_produit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ht = new System.Windows.Forms.Label();
            this.lbl_tps = new System.Windows.Forms.Label();
            this.lbl_tvq = new System.Windows.Forms.Label();
            this.lbl_ttc = new System.Windows.Forms.Label();
            this.lbl_mt_ht = new System.Windows.Forms.Label();
            this.lbl_mt_tps = new System.Windows.Forms.Label();
            this.lbl_mt_tvq = new System.Windows.Forms.Label();
            this.lbl_mt_ttc = new System.Windows.Forms.Label();
            this.txtbox_prix = new System.Windows.Forms.TextBox();
            this.txtbox_quantite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix unitaire: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité vendue: ";
            // 
            // txtbox_produit
            // 
            this.txtbox_produit.Location = new System.Drawing.Point(241, 44);
            this.txtbox_produit.Name = "txtbox_produit";
            this.txtbox_produit.Size = new System.Drawing.Size(100, 20);
            this.txtbox_produit.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ht
            // 
            this.lbl_ht.AutoSize = true;
            this.lbl_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ht.Location = new System.Drawing.Point(32, 250);
            this.lbl_ht.Name = "lbl_ht";
            this.lbl_ht.Size = new System.Drawing.Size(178, 24);
            this.lbl_ht.TabIndex = 7;
            this.lbl_ht.Text = "Montant hors taxes: ";
            this.lbl_ht.Visible = false;
            // 
            // lbl_tps
            // 
            this.lbl_tps.AutoSize = true;
            this.lbl_tps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tps.Location = new System.Drawing.Point(32, 294);
            this.lbl_tps.Name = "lbl_tps";
            this.lbl_tps.Size = new System.Drawing.Size(128, 24);
            this.lbl_tps.TabIndex = 8;
            this.lbl_tps.Text = "Montant TPS: ";
            this.lbl_tps.Visible = false;
            // 
            // lbl_tvq
            // 
            this.lbl_tvq.AutoSize = true;
            this.lbl_tvq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tvq.Location = new System.Drawing.Point(32, 334);
            this.lbl_tvq.Name = "lbl_tvq";
            this.lbl_tvq.Size = new System.Drawing.Size(132, 24);
            this.lbl_tvq.TabIndex = 9;
            this.lbl_tvq.Text = "Montant TVQ: ";
            this.lbl_tvq.Visible = false;
            // 
            // lbl_ttc
            // 
            this.lbl_ttc.AutoSize = true;
            this.lbl_ttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttc.ForeColor = System.Drawing.Color.Red;
            this.lbl_ttc.Location = new System.Drawing.Point(32, 379);
            this.lbl_ttc.Name = "lbl_ttc";
            this.lbl_ttc.Size = new System.Drawing.Size(103, 24);
            this.lbl_ttc.TabIndex = 10;
            this.lbl_ttc.Text = "Total TTC: ";
            this.lbl_ttc.Visible = false;
            // 
            // lbl_mt_ht
            // 
            this.lbl_mt_ht.AutoSize = true;
            this.lbl_mt_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mt_ht.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mt_ht.Location = new System.Drawing.Point(249, 250);
            this.lbl_mt_ht.Name = "lbl_mt_ht";
            this.lbl_mt_ht.Size = new System.Drawing.Size(0, 24);
            this.lbl_mt_ht.TabIndex = 11;
            // 
            // lbl_mt_tps
            // 
            this.lbl_mt_tps.AutoSize = true;
            this.lbl_mt_tps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mt_tps.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mt_tps.Location = new System.Drawing.Point(249, 294);
            this.lbl_mt_tps.Name = "lbl_mt_tps";
            this.lbl_mt_tps.Size = new System.Drawing.Size(0, 24);
            this.lbl_mt_tps.TabIndex = 12;
            // 
            // lbl_mt_tvq
            // 
            this.lbl_mt_tvq.AutoSize = true;
            this.lbl_mt_tvq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mt_tvq.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_mt_tvq.Location = new System.Drawing.Point(249, 334);
            this.lbl_mt_tvq.Name = "lbl_mt_tvq";
            this.lbl_mt_tvq.Size = new System.Drawing.Size(0, 24);
            this.lbl_mt_tvq.TabIndex = 13;
            // 
            // lbl_mt_ttc
            // 
            this.lbl_mt_ttc.AutoSize = true;
            this.lbl_mt_ttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mt_ttc.ForeColor = System.Drawing.Color.Red;
            this.lbl_mt_ttc.Location = new System.Drawing.Point(249, 379);
            this.lbl_mt_ttc.Name = "lbl_mt_ttc";
            this.lbl_mt_ttc.Size = new System.Drawing.Size(0, 24);
            this.lbl_mt_ttc.TabIndex = 14;
            // 
            // txtbox_prix
            // 
            this.txtbox_prix.Location = new System.Drawing.Point(241, 98);
            this.txtbox_prix.Name = "txtbox_prix";
            this.txtbox_prix.Size = new System.Drawing.Size(100, 20);
            this.txtbox_prix.TabIndex = 4;
            this.txtbox_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_prix_KeyPress);
            // 
            // txtbox_quantite
            // 
            this.txtbox_quantite.Location = new System.Drawing.Point(241, 146);
            this.txtbox_quantite.Name = "txtbox_quantite";
            this.txtbox_quantite.Size = new System.Drawing.Size(100, 20);
            this.txtbox_quantite.TabIndex = 5;
            this.txtbox_quantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_quantite_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.lbl_mt_ttc);
            this.Controls.Add(this.lbl_mt_tvq);
            this.Controls.Add(this.lbl_mt_tps);
            this.Controls.Add(this.lbl_mt_ht);
            this.Controls.Add(this.lbl_ttc);
            this.Controls.Add(this.lbl_tvq);
            this.Controls.Add(this.lbl_tps);
            this.Controls.Add(this.lbl_ht);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_quantite);
            this.Controls.Add(this.txtbox_prix);
            this.Controls.Add(this.txtbox_produit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Transaction simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_produit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ht;
        private System.Windows.Forms.Label lbl_tps;
        private System.Windows.Forms.Label lbl_tvq;
        private System.Windows.Forms.Label lbl_ttc;
        private System.Windows.Forms.Label lbl_mt_ht;
        private System.Windows.Forms.Label lbl_mt_tps;
        private System.Windows.Forms.Label lbl_mt_tvq;
        private System.Windows.Forms.Label lbl_mt_ttc;
        private System.Windows.Forms.TextBox txtbox_prix;
        private System.Windows.Forms.TextBox txtbox_quantite;
    }
}

