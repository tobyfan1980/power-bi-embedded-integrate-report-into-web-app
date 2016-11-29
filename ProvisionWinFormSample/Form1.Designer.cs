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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewWCName = new System.Windows.Forms.TextBox();
            this.btnNewWC = new System.Windows.Forms.Button();
            this.lblSubscriptionId = new System.Windows.Forms.Label();
            this.txtSubscriptionId = new System.Windows.Forms.TextBox();
            this.comboWorkspaces = new System.Windows.Forms.ComboBox();
            this.lblResourceGroup = new System.Windows.Forms.Label();
            this.lblWorkspaces = new System.Windows.Forms.Label();
            this.txtResourceGroup = new System.Windows.Forms.TextBox();
            this.btnLoadWC = new System.Windows.Forms.Button();
            this.lblWorkspaceCollection = new System.Windows.Forms.Label();
            this.comboWorkspaceCollections = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDatasetsTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEmbed = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(973, 647);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNewWCName);
            this.panel1.Controls.Add(this.btnNewWC);
            this.panel1.Controls.Add(this.lblSubscriptionId);
            this.panel1.Controls.Add(this.txtSubscriptionId);
            this.panel1.Controls.Add(this.comboWorkspaces);
            this.panel1.Controls.Add(this.lblResourceGroup);
            this.panel1.Controls.Add(this.lblWorkspaces);
            this.panel1.Controls.Add(this.txtResourceGroup);
            this.panel1.Controls.Add(this.btnLoadWC);
            this.panel1.Controls.Add(this.lblWorkspaceCollection);
            this.panel1.Controls.Add(this.comboWorkspaceCollections);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 114);
            this.panel1.TabIndex = 9;
            // 
            // txtNewWCName
            // 
            this.txtNewWCName.Enabled = false;
            this.txtNewWCName.Location = new System.Drawing.Point(585, 55);
            this.txtNewWCName.Name = "txtNewWCName";
            this.txtNewWCName.Size = new System.Drawing.Size(366, 20);
            this.txtNewWCName.TabIndex = 10;
            // 
            // btnNewWC
            // 
            this.btnNewWC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewWC.Location = new System.Drawing.Point(504, 55);
            this.btnNewWC.Name = "btnNewWC";
            this.btnNewWC.Size = new System.Drawing.Size(75, 21);
            this.btnNewWC.TabIndex = 9;
            this.btnNewWC.Text = "New";
            this.btnNewWC.UseVisualStyleBackColor = true;
            this.btnNewWC.Click += new System.EventHandler(this.btnNewWC_Click);
            // 
            // lblSubscriptionId
            // 
            this.lblSubscriptionId.Location = new System.Drawing.Point(6, 0);
            this.lblSubscriptionId.Name = "lblSubscriptionId";
            this.lblSubscriptionId.Size = new System.Drawing.Size(120, 13);
            this.lblSubscriptionId.TabIndex = 0;
            this.lblSubscriptionId.Text = "Subscription Id";
            // 
            // txtSubscriptionId
            // 
            this.txtSubscriptionId.Location = new System.Drawing.Point(132, 3);
            this.txtSubscriptionId.Name = "txtSubscriptionId";
            this.txtSubscriptionId.Size = new System.Drawing.Size(366, 20);
            this.txtSubscriptionId.TabIndex = 1;
            // 
            // comboWorkspaces
            // 
            this.comboWorkspaces.FormattingEnabled = true;
            this.comboWorkspaces.Location = new System.Drawing.Point(132, 82);
            this.comboWorkspaces.Name = "comboWorkspaces";
            this.comboWorkspaces.Size = new System.Drawing.Size(366, 21);
            this.comboWorkspaces.TabIndex = 7;
            this.comboWorkspaces.SelectedIndexChanged += new System.EventHandler(this.comboWorkspaces_SelectedIndexChanged);
            // 
            // lblResourceGroup
            // 
            this.lblResourceGroup.Location = new System.Drawing.Point(6, 26);
            this.lblResourceGroup.Name = "lblResourceGroup";
            this.lblResourceGroup.Size = new System.Drawing.Size(120, 13);
            this.lblResourceGroup.TabIndex = 2;
            this.lblResourceGroup.Text = "Resource Group";
            // 
            // lblWorkspaces
            // 
            this.lblWorkspaces.Location = new System.Drawing.Point(6, 79);
            this.lblWorkspaces.Name = "lblWorkspaces";
            this.lblWorkspaces.Size = new System.Drawing.Size(120, 13);
            this.lblWorkspaces.TabIndex = 6;
            this.lblWorkspaces.Text = "Workspaces";
            // 
            // txtResourceGroup
            // 
            this.txtResourceGroup.Location = new System.Drawing.Point(132, 29);
            this.txtResourceGroup.Name = "txtResourceGroup";
            this.txtResourceGroup.Size = new System.Drawing.Size(366, 20);
            this.txtResourceGroup.TabIndex = 3;
            // 
            // btnLoadWC
            // 
            this.btnLoadWC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadWC.Location = new System.Drawing.Point(504, 28);
            this.btnLoadWC.Name = "btnLoadWC";
            this.btnLoadWC.Size = new System.Drawing.Size(75, 21);
            this.btnLoadWC.TabIndex = 8;
            this.btnLoadWC.Text = "Load";
            this.btnLoadWC.UseVisualStyleBackColor = true;
            this.btnLoadWC.Click += new System.EventHandler(this.btnLoadWC_Click);
            // 
            // lblWorkspaceCollection
            // 
            this.lblWorkspaceCollection.Location = new System.Drawing.Point(6, 52);
            this.lblWorkspaceCollection.Name = "lblWorkspaceCollection";
            this.lblWorkspaceCollection.Size = new System.Drawing.Size(120, 13);
            this.lblWorkspaceCollection.TabIndex = 4;
            this.lblWorkspaceCollection.Text = "Workspace Collection";
            // 
            // comboWorkspaceCollections
            // 
            this.comboWorkspaceCollections.Location = new System.Drawing.Point(132, 55);
            this.comboWorkspaceCollections.Name = "comboWorkspaceCollections";
            this.comboWorkspaceCollections.Size = new System.Drawing.Size(366, 21);
            this.comboWorkspaceCollections.TabIndex = 5;
            this.comboWorkspaceCollections.SelectedIndexChanged += new System.EventHandler(this.comboWorkspaceCollections_SelectedIndexChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private System.Windows.Forms.Button btnEmbed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadWC;
        private System.Windows.Forms.Button btnNewWC;
        private System.Windows.Forms.TextBox txtNewWCName;
    }
}

