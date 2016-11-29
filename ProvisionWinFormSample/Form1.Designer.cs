namespace ProvisionWinFormSample
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubscriptionId = new System.Windows.Forms.Label();
            this.txtSubscriptionId = new System.Windows.Forms.TextBox();
            this.lblResourceGroup = new System.Windows.Forms.Label();
            this.txtResourceGroup = new System.Windows.Forms.TextBox();
            this.lblWorkspaceCollection = new System.Windows.Forms.Label();
            this.comboWorkspaceCollections = new System.Windows.Forms.ComboBox();
            this.btnLoadWC = new System.Windows.Forms.Button();
            this.lblWorkspaces = new System.Windows.Forms.Label();
            this.comboWorkspaces = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDatasetsTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEmbed = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(973, 647);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblSubscriptionId);
            this.flowLayoutPanel2.Controls.Add(this.txtSubscriptionId);
            this.flowLayoutPanel2.Controls.Add(this.lblResourceGroup);
            this.flowLayoutPanel2.Controls.Add(this.txtResourceGroup);
            this.flowLayoutPanel2.Controls.Add(this.lblWorkspaceCollection);
            this.flowLayoutPanel2.Controls.Add(this.comboWorkspaceCollections);
            this.flowLayoutPanel2.Controls.Add(this.btnLoadWC);
            this.flowLayoutPanel2.Controls.Add(this.lblWorkspaces);
            this.flowLayoutPanel2.Controls.Add(this.comboWorkspaces);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(970, 114);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblSubscriptionId
            // 
            this.lblSubscriptionId.Location = new System.Drawing.Point(3, 0);
            this.lblSubscriptionId.Name = "lblSubscriptionId";
            this.lblSubscriptionId.Size = new System.Drawing.Size(120, 13);
            this.lblSubscriptionId.TabIndex = 0;
            this.lblSubscriptionId.Text = "Subscription Id";
            // 
            // txtSubscriptionId
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.txtSubscriptionId, true);
            this.txtSubscriptionId.Location = new System.Drawing.Point(129, 3);
            this.txtSubscriptionId.Name = "txtSubscriptionId";
            this.txtSubscriptionId.Size = new System.Drawing.Size(366, 20);
            this.txtSubscriptionId.TabIndex = 1;
            // 
            // lblResourceGroup
            // 
            this.lblResourceGroup.Location = new System.Drawing.Point(3, 26);
            this.lblResourceGroup.Name = "lblResourceGroup";
            this.lblResourceGroup.Size = new System.Drawing.Size(120, 13);
            this.lblResourceGroup.TabIndex = 2;
            this.lblResourceGroup.Text = "Resource Group";
            // 
            // txtResourceGroup
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.txtResourceGroup, true);
            this.txtResourceGroup.Location = new System.Drawing.Point(129, 29);
            this.txtResourceGroup.Name = "txtResourceGroup";
            this.txtResourceGroup.Size = new System.Drawing.Size(366, 20);
            this.txtResourceGroup.TabIndex = 3;
            // 
            // lblWorkspaceCollection
            // 
            this.lblWorkspaceCollection.Location = new System.Drawing.Point(3, 52);
            this.lblWorkspaceCollection.Name = "lblWorkspaceCollection";
            this.lblWorkspaceCollection.Size = new System.Drawing.Size(120, 13);
            this.lblWorkspaceCollection.TabIndex = 4;
            this.lblWorkspaceCollection.Text = "Workspace Collection";
            // 
            // comboWorkspaceCollections
            // 
            this.comboWorkspaceCollections.Location = new System.Drawing.Point(129, 55);
            this.comboWorkspaceCollections.Name = "comboWorkspaceCollections";
            this.comboWorkspaceCollections.Size = new System.Drawing.Size(366, 21);
            this.comboWorkspaceCollections.TabIndex = 5;
            this.comboWorkspaceCollections.SelectedIndexChanged += new System.EventHandler(this.comboWorkspaceCollections_SelectedIndexChanged);
            // 
            // btnLoadWC
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.btnLoadWC, true);
            this.btnLoadWC.Location = new System.Drawing.Point(501, 29);
            this.btnLoadWC.Name = "btnLoadWC";
            this.btnLoadWC.Size = new System.Drawing.Size(75, 23);
            this.btnLoadWC.TabIndex = 8;
            this.btnLoadWC.Text = "Load";
            this.btnLoadWC.UseVisualStyleBackColor = true;
            this.btnLoadWC.Click += new System.EventHandler(this.btnLoadWC_Click);
            // 
            // lblWorkspaces
            // 
            this.lblWorkspaces.Location = new System.Drawing.Point(3, 81);
            this.lblWorkspaces.Name = "lblWorkspaces";
            this.lblWorkspaces.Size = new System.Drawing.Size(120, 13);
            this.lblWorkspaces.TabIndex = 6;
            this.lblWorkspaces.Text = "Workspaces";
            // 
            // comboWorkspaces
            // 
            this.comboWorkspaces.FormattingEnabled = true;
            this.comboWorkspaces.Location = new System.Drawing.Point(129, 84);
            this.comboWorkspaces.Name = "comboWorkspaces";
            this.comboWorkspaces.Size = new System.Drawing.Size(366, 21);
            this.comboWorkspaces.TabIndex = 7;
            this.comboWorkspaces.SelectedIndexChanged += new System.EventHandler(this.comboWorkspaces_SelectedIndexChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblDatasetsTitle);
            this.flowLayoutPanel3.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel3.Controls.Add(this.lblReportsTitle);
            this.flowLayoutPanel3.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel3.Controls.Add(this.btnEmbed);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 123);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(970, 504);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // lblDatasetsTitle
            // 
            this.lblDatasetsTitle.AutoSize = true;
            this.lblDatasetsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasetsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblDatasetsTitle.Name = "lblDatasetsTitle";
            this.lblDatasetsTitle.Size = new System.Drawing.Size(64, 17);
            this.lblDatasetsTitle.TabIndex = 0;
            this.lblDatasetsTitle.Text = "Datasets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(967, 202);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsTitle.Location = new System.Drawing.Point(3, 235);
            this.lblReportsTitle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(58, 17);
            this.lblReportsTitle.TabIndex = 2;
            this.lblReportsTitle.Text = "Reports";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(967, 209);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnEmbed
            // 
            this.btnEmbed.Location = new System.Drawing.Point(3, 470);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(75, 23);
            this.btnEmbed.TabIndex = 4;
            this.btnEmbed.Text = "Embed Selected Report";
            this.btnEmbed.UseVisualStyleBackColor = true;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 671);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "PowerBI PAAS Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblSubscriptionId;
        private System.Windows.Forms.TextBox txtSubscriptionId;
        private System.Windows.Forms.Label lblResourceGroup;
        private System.Windows.Forms.TextBox txtResourceGroup;
        private System.Windows.Forms.Label lblWorkspaceCollection;
        private System.Windows.Forms.ComboBox comboWorkspaceCollections;
        private System.Windows.Forms.Label lblWorkspaces;
        private System.Windows.Forms.ComboBox comboWorkspaces;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblDatasetsTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLoadWC;
        private System.Windows.Forms.Button btnEmbed;
    }
}

