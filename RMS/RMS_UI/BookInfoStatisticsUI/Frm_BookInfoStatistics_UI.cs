using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;

namespace RMS.UI
{
    public partial class Frm_BookInfoStatistics : Form
    {
        public Frm_BookInfoStatistics()
        {
            InitializeComponent();
        }

        List<string> xData = new List<string>() { "A", "B", "C", "D" };
        List<double> yData = new List<double>() { 10.0, 20.0, 30.0, 40.0 };

        private void BookInfoStatistics_UI_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            DrawPie();
        }

        private void DrawPie()
        {
            Series Series1 = new Series();
            
            chart1.Series.Add(Series1);
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Legends[0].Enabled = true;
            chart1.Series["Series1"].LegendText = "#INDEX:#VALX";//开启图例
            chart1.Series["Series1"].Label = "#INDEX:#PERCENT";
            chart1.Series["Series1"].IsXValueIndexed = false;
            chart1.Series["Series1"].IsValueShownAsLabel = false;
            chart1.Series["Series1"]["PieLineColor"] = "Black";//连线颜色
            chart1.Series["Series1"]["PieLabelStyle"] = "Outside";//标签位置
            chart1.Series["Series1"].ToolTip = "#VALX";//显示提示用语
            chart1.Series["Series1"].Points.DataBindXY(xData, yData);
            ChartArea ChartArea1 = new ChartArea();
            chart1.ChartAreas.Add(ChartArea1);
            //开启三维模式的原因是为了避免标签重叠
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;//开启三维模式;PointDepth:厚度BorderWidth:边框宽
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Rotation = 15;//起始角度
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 45;//倾斜度(0～90)
            chart1.ChartAreas["ChartArea1"].Area3DStyle.LightStyle = LightStyle.Realistic;//表面光泽度
            chart1.Show();
        }

        private void DrawColunm()
        {
            Series Series1 = new Series();
            chart1.Series.Add(Series1);
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            chart1.Legends[0].Enabled = false;
            chart1.Series["Series1"].LegendText = "";
            chart1.Series["Series1"].Label = "#VALY";
            chart1.Series["Series1"].ToolTip = "#VALX";
            chart1.Series["Series1"]["PointWidth"] = "0.5";
            ChartArea ChartArea1 = new ChartArea();
            chart1.ChartAreas.Add(ChartArea1);
            //开启三维模式的原因是为了避免标签重叠
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;//开启三维模式;PointDepth:厚度BorderWidth:边框宽
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Rotation = 15;//起始角度
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 30;//倾斜度(0～90)
            chart1.ChartAreas["ChartArea1"].Area3DStyle.LightStyle = LightStyle.Realistic;//表面光泽度
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1; //决定x轴显示文本的间隔，1为强制每个柱状体都显示，3则间隔3个显示
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new Font("宋体", 9, FontStyle.Regular);
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        }

        //public Bitmap GetBitmap(int width, int heigh, int r, string familyName, Dictionary<string, double> data)
        //{
        //    Bitmap bitmap = new Bitmap(width, heigh);
        //    Graphics graphics = Graphics.FromImage(bitmap);

        //    //用白色填充整个图片，因为默认是黑色           
        //    graphics.Clear(Color.White);

        //    //抗锯齿           
        //    graphics.SmoothingMode = SmoothingMode.HighQuality;

        //    //高质量的文字           
        //    graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        //    //像素均偏移0.5个单位，以消除锯齿           
        //    graphics.PixelOffsetMode = PixelOffsetMode.Half;

        //    //第一个色块的原点位置           
        //    PointF basePoint = new PointF(10, 20);

        //    //色块的大小           

        //    SizeF theSize = new SizeF(45, 16);
        //    //第一个色块的说明文字的位置           

        //    PointF textPoint = new PointF(basePoint.X + 50, basePoint.Y);

        //    foreach (var item in data)
        //    {
        //        RectangleF baseRectangle = new RectangleF(basePoint, theSize);
        //        //画代表色块               
        //        graphics.FillRectangle(new SolidBrush(getColor(item.Key.ToString())), baseRectangle);
        //        graphics.DrawString(item.Key.ToString(), new Font(familyName, 11), Brushes.Black, textPoint);
        //        basePoint.Y += 30;
        //        textPoint.Y += 30;
        //    }
        //    //扇形区所在边框的原点位置           
        //    Point circlePoint = new Point(Convert.ToInt32(textPoint.X + 90), 35);
        //    //总比初始值           
        //    float totalRate = 0;

        //    //起始角度 Y周正方向           
        //    float startAngle = 30;

        //    //当前比初始值           
        //    float currentRate = 0;

        //    //圆所在边框的大小           

        //    Size cicleSize = new Size(r * 2, r * 2);

        //    //圆所在边框的位置           

        //    Rectangle circleRectangle = new Rectangle(circlePoint, cicleSize);

        //    foreach (var item in data)
        //    {
        //        totalRate += float.Parse(item.Value.ToString());
        //    }

        //    foreach (var item in data)
        //    {
        //        currentRate = float.Parse(item.Value.ToString()) / totalRate * 360;
        //        graphics.DrawPie(Pens.White, circleRectangle, startAngle, currentRate);
        //        graphics.FillPie(new SolidBrush(getColor(item.Key.ToString())), circleRectangle, startAngle, currentRate);
        //        //至此 扇形图已经画完，下面是在扇形图上写上说明文字
        //        //当前圆的圆心 相对图片边框原点的坐标               
        //        PointF cPoint = new PointF(circlePoint.X + r, circlePoint.Y + r);
        //        //当前圆弧上的点               
        //        //cos(弧度)=X轴坐标/r               
        //        //弧度=角度*π/180               
        //        double relativeCurrentX = r * Math.Cos((360 - startAngle - currentRate / 2) * Math.PI / 180);
        //        double relativecurrentY = r * Math.Sin((360 - startAngle - currentRate / 2) * Math.PI / 180);
        //        double currentX = relativeCurrentX + cPoint.X;
        //        double currentY = cPoint.Y - relativecurrentY;
        //        //内圆上弧上的 浮点型坐标               
        //        PointF currentPoint = new PointF(float.Parse(currentX.ToString()), float.Parse(currentY.ToString()));
        //        //外圆弧上的点          
        //        double largerR = r + 25;
        //        double relativeLargerX = largerR * Math.Cos((360 - startAngle - currentRate / 2) * Math.PI / 180);
        //        double relativeLargerY = largerR * Math.Sin((360 - startAngle - currentRate / 2) * Math.PI / 180);
        //        double largerX = relativeLargerX + cPoint.X;
        //        double largerY = cPoint.Y - relativeLargerY;
        //        //外圆上弧上的 浮点型坐标                
        //        PointF largerPoint = new PointF(float.Parse(largerX.ToString()), float.Parse(largerY.ToString()));
        //        //将两个点连起来                
        //        //graphics.DrawLine(Pens.Black, currentPoint, largerPoint);
        //        //外圆上 说明文字的位置                
        //        PointF circleTextPoint = new PointF(float.Parse(largerX.ToString()), float.Parse(largerY.ToString()));
        //        //在外圆上的点的附近合适的位置 写上说明                
        //        if (largerX >= 0 && largerY >= 0)//第1象限  实际第二象限                
        //        {
        //            //circleTextPoint.Y -= 15;                    
        //            circleTextPoint.X -= 35;
        //        }

        //        if (largerX <= 0 && largerY >= 0)//第2象限  实际第三象限                
        //        {
        //            //circleTextPoint.Y -= 15;                    

        //            //circleTextPoint.X -= 65;                

        //        }

        //        if (largerX <= 0 && largerY <= 0)//第3象限  实际第四象限                

        //        {

        //            //circleTextPoint.X -= 45;               

        //            circleTextPoint.Y += 30;

        //        }

        //        if (largerX >= 0 && largerY <= 0)//第4象限  实际第一象限                

        //        {

        //            circleTextPoint.X -= 15;

        //            //circleTextPoint.Y += 5;                

        //        }

        //        //象限差异解释：在数学中 二维坐标轴中 右上方 全为正，在计算机处理图像时，右下方全为正。相当于顺时针移了一个象限序号                              

        //        graphics.DrawString(item.Key.ToString() + " " + (currentRate / 360).ToString("p2"), new Font(familyName, 11), Brushes.Black, circleTextPoint);

        //        startAngle += currentRate;

        //    }

        //    return bitmap;

        //}

        ///// <summary>
        ///// 获得配色
        ///// </summary>
        ///// <param name="scoreLevel"></param>
        ///// <returns></returns>
        //Color getColor(string scoreLevel)
        //{

        //    Color c = Color.White;

        //    if (scoreLevel.Contains("优秀"))

        //        c = Color.FromArgb(57, 134, 155);

        //    if (scoreLevel.Contains("良好"))

        //        c = Color.FromArgb(70, 161, 185);

        //    if (scoreLevel.Contains("一般"))

        //        c = Color.FromArgb(124, 187, 207);

        //    if (scoreLevel.Contains("不及格"))

        //        c = Color.FromArgb(181, 212, 224);

        //    return c;

        //}

        //public Bitmap GetBargraph(int width, int heigh, string familyName, Dictionary<string, double> data, int PaperScore)
        //{
        //    if (data != null)
        //    {
        //        Bitmap bitmap = new Bitmap(width, heigh);
        //        Graphics graphics = Graphics.FromImage(bitmap);

        //        //用白色填充整个图片，因为默认是黑色               
        //        graphics.Clear(Color.White);

        //        //抗锯齿           
        //        graphics.SmoothingMode = SmoothingMode.HighQuality;

        //        //高质量的文字             
        //        graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        //        //像素均偏移0.5个单位，以消除锯齿            
        //        graphics.PixelOffsetMode = PixelOffsetMode.Half;

        //        double maxCount = 0;

        //        //以最多人数为基准            

        //        foreach (var item in data) if (Convert.ToDouble(item.Value.ToString()) > maxCount)

        //                maxCount = Convert.ToDouble(item.Value.ToString());

        //        //在距离底部25像素的地方 画上分数线 并标上四个分数         

        //        //该分数线的宽度是图片宽度的85%             

        //        //分数线原点位置        

        //        PointF scoreLineStartPoint = new PointF(width * 0.15f / 2f, heigh - 25f);

        //        //分数线终点位置               

        //        PointF scoreLineEndPoint = new PointF(scoreLineStartPoint.X + width * 0.85f, scoreLineStartPoint.Y);

        //        graphics.DrawLine(Pens.Black, scoreLineStartPoint, scoreLineEndPoint);

        //        //定义：最多人数的那项占图片高度的85%             

        //        //每项*高度的85%/maxCount=该项的高度

        //        float currentX = width * 0.85f * (1f / 9)//直线上的1/9处为起点            

        //+ width * 0.15f / 2// 图片的两边 空 15%  ，每边空15%的一半                     ;        

        //float perWidth = width * 0.85f * (1f / 9);

        //        foreach (var item in data)
        //        {

        //            //当前等级的原点描述：Height-25-(人数*0.9/maxcount)           

        //            float currentHeight = (float)item.Value * 0.85f * heigh / (float)maxCount;

        //            //颜色 全部用淡蓝色                 

        //            graphics.FillRectangle(new SolidBrush(Color.FromArgb(70, 161, 187)), currentX, heigh - 25 - currentHeight - 1, perWidth, currentHeight);

        //            //画当前区间的左边的线                 

        //            graphics.DrawLine(Pens.Black, currentX, scoreLineStartPoint.Y, currentX, scoreLineStartPoint.Y + 3);

        //            //在上面5像素处写上人数

        //            graphics.DrawString(item.Value.ToString() + "（人）", new Font(familyName, 11), Brushes.Black, currentX - 4, heigh - 25 - currentHeight - 1 - 18);

        //            graphics.DrawString(item.Key.ToString(), new Font(familyName, 11), Brushes.Black, currentX, scoreLineStartPoint.Y + 3);

        //            currentX += perWidth;//向右移一个柱形宽度单位              

        //            //画当前区间的右边的线                

        //            graphics.DrawLine(Pens.Black, currentX, scoreLineStartPoint.Y, currentX, scoreLineStartPoint.Y + 3);

        //            currentX += perWidth;//向右移一个柱形宽度单位                 }

        //            graphics.DrawString("（等级）", new Font(familyName, 11), Brushes.Black, currentX - perWidth + 3f, scoreLineStartPoint.Y + 3);

        //            return bitmap;
        //        }
        //    }
        //    else return null;
        //}

        //private void Init()
        //{
        //    string datas = context.Request.QueryString["data"];

        //    ScoreStatistics s = new ScoreStatistics();

        //    data = s.TransferToObject<Dictionary<string, double>>(datas);



        //    MemoryStream mem = new MemoryStream();

        //    Bitmap chart = scoreStaticsBLL.GetBargraph(450, 280, "宋体", data, 120);

        //    chart.Save(mem, ImageFormat.Jpeg);

        //    context.Response.ContentType = "image/jpeg";

        //    context.Response.BinaryWrite(mem.ToArray());
        //}


    }
}
