﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf06_listview
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string currFolder = Environment.CurrentDirectory;   // 현재 프로그램 실행경로  .\bin\debug\
            DirectoryInfo di = new DirectoryInfo(currFolder);
            FileInfo[] files = di.GetFiles();                   // 현재 디렉토리 내 파일 배열

            LsvFiles.BeginUpdate();          // 업데이트 완료전까지는 UI갱신 중지
            LsvFiles.View = View.Details;    // 리스트뷰 화면 자세히보기로
            CboView.SelectedIndex = 0;       // 뷰보기 콤보박스의 첫번째 값으로 지정

            // Lsvview에 사용할 아이콘 지정
            LsvFiles.LargeImageList = ImgLargeIcon;
            LsvFiles.SmallImageList = ImgSmallIcon;

            foreach (FileInfo file in files)
            {
                // 각 파일별로 ListViewItem 객체를 만들어서 하나씩 지정
                ListViewItem lvi = new ListViewItem(file.Name);
                lvi.SubItems.Add(file.LastWriteTime.ToString());

                var ext = Path.GetExtension(file.Name);
                var extName = "";
                switch (ext) {
                    case ".exe":
                        extName = "응용프로그램";
                        break;
                    case ".config":
                        extName = "Configuration 원본파일";
                        break;
                    case ".pdb":
                        extName = "Program Debug Database";
                        break;
                    default:
                        extName = "기타";
                        break;

                }

                if (ext == ".exe")
                {
                    lvi.ImageIndex = 0;
                }
                else
                {
                    lvi.ImageIndex = 1;
                }

                lvi.SubItems.Add(extName);  // 유형
                var fileSize = file.Length / 1024;
                lvi.SubItems.Add(string.Format("{0} KB", fileSize));
                //lvi.SubItems.Add(file.Length.ToString());
                // 아이콘은 나중에

                LsvFiles.Items.Add(lvi);
            }

            LsvFiles.EndUpdate();       // 업데이트 끝낫으니 ui갱신
        }

        private void CboView_SelectedIndexChanged(object sender, EventArgs e)
        {

            var indexVal = CboView.SelectedIndex;
            switch (indexVal)
            {
                case 0: // Details
                    LsvFiles.View = View.Details;
                    break;
                case 1:
                    LsvFiles.View = View.List;
                    break;
                case 2:
                    LsvFiles.View = View.Tile;
                    break;
                case 3:
                    LsvFiles.View= View.SmallIcon;
                    break;
                case 4:
                    LsvFiles.View = View.LargeIcon;
                    break;
                case 5:
                    LsvFiles.View = View.Details;
                    break;
            }
        }
    }
}
