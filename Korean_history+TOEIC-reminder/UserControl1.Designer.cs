// 소스참조 <http://ojc.asia/bbs/board.php?bo_table=LecCsharpNet&wr_id=53>

using System.Windows.Forms;

namespace Korean_history_TOEIC_reminder
{
    partial class UserControl1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        /// 
        
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toeicLabel = new System.Windows.Forms.Label();
            this.toeicLink = new System.Windows.Forms.LinkLabel();
            this.khistoryLabel = new System.Windows.Forms.Label();
            this.khistoryLink = new System.Windows.Forms.LinkLabel();
            this.toeicResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khistoryResult = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toeicResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khistoryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // toeicLabel
            // 
            this.toeicLabel.AutoSize = true;
            this.toeicLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toeicLabel.Location = new System.Drawing.Point(14, 18);
            this.toeicLabel.Name = "toeicLabel";
            this.toeicLabel.Size = new System.Drawing.Size(151, 20);
            this.toeicLabel.TabIndex = 1;
            this.toeicLabel.Text = "토익 시험 일정";
            // 
            // toeicLink
            // 
            this.toeicLink.AutoSize = true;
            this.toeicLink.Location = new System.Drawing.Point(15, 42);
            this.toeicLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toeicLink.Name = "toeicLink";
            this.toeicLink.Size = new System.Drawing.Size(65, 15);
            this.toeicLink.TabIndex = 2;
            this.toeicLink.TabStop = true;
            this.toeicLink.Text = "toeicLink";
            this.toeicLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toeicLink_LinkClicked);
            // 
            // khistoryLabel
            // 
            this.khistoryLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.khistoryLabel.Location = new System.Drawing.Point(15, 322);
            this.khistoryLabel.Name = "khistoryLabel";
            this.khistoryLabel.Size = new System.Drawing.Size(172, 20);
            this.khistoryLabel.TabIndex = 1;
            this.khistoryLabel.Text = "한국사 시험 일정";
            // 
            // khistoryLink
            // 
            this.khistoryLink.AutoSize = true;
            this.khistoryLink.Location = new System.Drawing.Point(18, 341);
            this.khistoryLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.khistoryLink.Name = "khistoryLink";
            this.khistoryLink.Size = new System.Drawing.Size(84, 15);
            this.khistoryLink.TabIndex = 2;
            this.khistoryLink.TabStop = true;
            this.khistoryLink.Text = "khistoryLink";
            this.khistoryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.khistoryLink_LinkClicked);
            // 
            // toeicResult
            // 
            this.toeicResult.AllowUserToAddRows = false;
            this.toeicResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.toeicResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.toeicResult.ColumnHeadersHeight = 29;
            this.toeicResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.toeicResult.DefaultCellStyle = dataGridViewCellStyle4;
            this.toeicResult.Location = new System.Drawing.Point(12, 64);
            this.toeicResult.Name = "toeicResult";
            this.toeicResult.ReadOnly = true;
            this.toeicResult.RowHeadersVisible = false;
            this.toeicResult.RowHeadersWidth = 51;
            this.toeicResult.Size = new System.Drawing.Size(796, 242);
            this.toeicResult.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "컬럼1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "컬럼2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "컬럼3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "컬럼4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // khistoryResult
            // 
            this.khistoryResult.AllowUserToAddRows = false;
            this.khistoryResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.khistoryResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.khistoryResult.ColumnHeadersHeight = 29;
            this.khistoryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.khistoryResult.DefaultCellStyle = dataGridViewCellStyle4;
            this.khistoryResult.Location = new System.Drawing.Point(12, 368);
            this.khistoryResult.Name = "khistoryResult";
            this.khistoryResult.ReadOnly = true;
            this.khistoryResult.RowHeadersVisible = false;
            this.khistoryResult.RowHeadersWidth = 51;
            this.khistoryResult.RowTemplate.Height = 27;
            this.khistoryResult.Size = new System.Drawing.Size(796, 212);
            this.khistoryResult.TabIndex = 5;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 611);
            this.Controls.Add(this.khistoryResult);
            this.Controls.Add(this.toeicLabel);
            this.Controls.Add(this.toeicLink);
            this.Controls.Add(this.toeicResult);
            this.Controls.Add(this.khistoryLabel);
            this.Controls.Add(this.khistoryLink);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl1";
            this.Text = "한국사 토익 알리미";
            ((System.ComponentModel.ISupportInitialize)(this.toeicResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khistoryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toeicLabel;        
        private System.Windows.Forms.LinkLabel toeicLink;
        private System.Windows.Forms.DataGridView toeicResult;
        private System.Windows.Forms.Label khistoryLabel;
        private System.Windows.Forms.LinkLabel khistoryLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DataGridView khistoryResult;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
