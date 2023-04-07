using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf04_filecopy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();   // 모달창
            if (result == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        // 일반적인 동기식 파일복사


        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
        }

        private async long CopySync(string fromFile, string toFile)
        {
            BtnAsyncCopy.Enabled = false;       // 비동기복사 버튼 일시 비활성화
            long totalCopied = 0;

            using (FileStream fromStrem = new FileStream(fromFile, FileMode.Open))
            { // 원본파일은 열고
                using (FileStream toStream =  new FileStream(toFile, FileMode.Create))
                {   // 타겟파일은 생성
                    byte[] buffer = new byte[1024 * 1024];      // 1MByte 버퍼
                    int nRead = 0;
                    while ((nRead = await fromStrem.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        // 프로그래스바에 표시
                        PgbCopy.Value = (int)(totalCopied / (double)fromStrem.Length) * PgbCopy.Maximum;
                    }
                }
            }

            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }


        // 비동기는 호출할때는 await사용, 구현할 때는 async사용

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)   
        {
            long totalCopied = await CopyAsync(TxtSource.Text, TxtTarget.Text);
        }
        private async Task<long> CopyAsync(string fromFile, string toFile)
        {
            BtnSyncCopy.Enabled = false;        // 동기복사 버튼 비활성화
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

    }

}
