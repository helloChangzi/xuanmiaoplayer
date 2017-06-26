namespace VideoPlay
{
    partial class ListElement
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.number = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Collection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.number.Location = new System.Drawing.Point(0, 0);
            this.number.Margin = new System.Windows.Forms.Padding(0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(23, 16);
            this.number.TabIndex = 0;
            this.number.Text = "01.";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.name.Location = new System.Drawing.Point(23, 0);
            this.name.Margin = new System.Windows.Forms.Padding(0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 16);
            this.name.TabIndex = 1;
            this.name.Text = "瑞克与莫蒂.Rick and Morty.S01E01.HR-HDTV.1024x576.中英双语-电波字幕组";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.time.Location = new System.Drawing.Point(123, 0);
            this.time.Margin = new System.Windows.Forms.Padding(0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(62, 16);
            this.time.TabIndex = 2;
            this.time.Text = "00:22:03";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Collection
            // 
            this.Collection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Collection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Collection.BackgroundImage = global::VideoPlay.Properties.Resources.collection_gray2;
            this.Collection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Collection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collection.Location = new System.Drawing.Point(185, 0);
            this.Collection.Name = "Collection";
            this.Collection.Size = new System.Drawing.Size(16, 16);
            this.Collection.TabIndex = 4;
            this.Collection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Collection.UseVisualStyleBackColor = false;
            this.Collection.Click += new System.EventHandler(this.Collection_Click);
            // 
            // ListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Collection);
            this.Controls.Add(this.time);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListElement";
            this.Size = new System.Drawing.Size(201, 16);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button Collection;
    }
}
