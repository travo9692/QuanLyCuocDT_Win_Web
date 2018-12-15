<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLY_CUOC.aspx.cs" Inherits="QL_cuoc_dt.QLY_CUOC" %>

  
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
 <script src="Content/jquery-3.3.1.min.js"></script>
     <script src="Content/js/bootstrap.min.js"></script>
</head>
<body style="height: 314px; background:#F0F0F0" >
    <form id="form1" runat="server">
          <div class ="container"  >
        
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/789_940_162_767_thecao-vina.jpg" Width="100%" Height="300px"  />
        </p>
      
        
        </div>

        
         
        <div class ="container" style="background:white;border:2px solid #e6e6e6;">
                  
           <div><h2 style="padding-left:250px;">TRA CỨU THÔNG TIN CƯỚC ĐIỆN THOẠI</h2>
        
        
        
        
            <div class ="row">
             <div class="col-md-6">  
                 <div style="border:2px solid #e6e6e6;  height:270px;">
                 <div style="padding-top:20px;padding-left:30px;"><asp:Label ID="Label2" runat="server" Text="Nhập số điện thoại:"></asp:Label>
        &nbsp;
        &nbsp;&nbsp;
                     <div  style="padding-right:10px;float:right;"><asp:TextBox ID="TextBox1" runat="server" Width="138px" Height="27px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Vui lòng nhập" ForeColor="Red">Bạn chưa nhập dữ liệu</asp:RequiredFieldValidator>
                     </div>
                     <br />
        &nbsp;&nbsp;
            </div> 
                 <div style="padding-left:30px;">
        <asp:Label ID="Label3" runat="server" Text="Ngày bắt đầu:"></asp:Label>
                 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div  style="padding-right:10px;float:right;"><asp:TextBox ID="TextBox2" runat="server" Width="138px" TextMode="Date"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Vui lòng nhập" ForeColor="Red">Bạn chưa nhập dữ liệu</asp:RequiredFieldValidator>

        </div>

                 <br />
        &nbsp;&nbsp;</div>
                 <div style="padding-left:30px;">
                  <asp:Label ID="Label4" runat="server" Text="Ngày kết thúc:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div  style="padding-right:10px;float:right;"><asp:TextBox ID="TextBox3" runat="server" TextMode="Date" Width="138px"></asp:TextBox>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Vui lòng nhập" ForeColor="Red">Bạn chưa nhập dữ liệu</asp:RequiredFieldValidator>
                     </div>
                 </div>
                
                     <asp:Button ID="Button1" runat="server" Text="Xem CTSD" Width="125px" CssClass="btn-search" OnClick="Button1_Click1" />
                     <asp:Button ID="Button4" runat="server" CssClass="btn-cuoc"  Width="125px" OnClick="Button4_Click" Text="Tính cước" />
                     
                 </div>
                 </div>
                
             <div class ="col-md-6">
        <div style="border:2px solid #e6e6e6; height:270px;">
            <div style="margin-left:20px; margin-top: 20px;">Hướng dẫn tra cứu:
                <p>-Khách hàng có nhu cầu tra cứu cước sử dụng điện thoại, vui lòng nhập đầy đủ thông tin ở cả 3 ô. Trong đó, ngày bắt đầu và ngày kết thúc là thời gian mà khách hàng muốn xem chi tiết sử dụng dịch vụ. 
            </p><p>Giá cước gọi:</p>
            <p>Phút ngày (7:00-23:00): 200 đồng/1 phút</p>
            <p>Phút đêm (23:00-7:00): 150 đồng/1 phút</p>
                </div>
             </div>
                 
            
        </div>
        </div>
                    
                
            
        </div>
            
            </div>
        <div class ="container" style="background:white;border:2px solid #e6e6e6;">

        <asp:Panel ID="Panel2" runat="server">
           
            <asp:GridView ID="GridView2" runat="server" style="width:80%;" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>

        </asp:Panel>
                    
        <asp:Panel ID="Panel3" runat="server">
        <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
         
            &nbsp;</asp:Panel>
           
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            </div>
    </form>
</body>
</html>
