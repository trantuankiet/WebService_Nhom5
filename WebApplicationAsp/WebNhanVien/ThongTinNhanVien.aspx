<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThongTinNhanVien.aspx.cs" Inherits="WebNhanVien.ThongTinNhanVien" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v12.1, Version=12.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxHtmlEditor.v12.1, Version=12.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHtmlEditor" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v12.1, Version=12.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 120px;
        }
        .style3
        {
            text-align: right;
            width: 237px;
        }
        .style5
        {
            width: 232px;
        }
        .style6
        {
            width: 262px;
        }
        .style7
        {
            width: 251px;
        }
    .auto-style1 {
        width: 120px;
        height: 19px;
    }
    .auto-style2 {
        text-align: right;
        width: 237px;
        height: 19px;
    }
    .auto-style3 {
        width: 251px;
        height: 19px;
    }
    .auto-style4 {
        height: 19px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div id="linebreak"></div>
   <div id="listtitle"><div id="listtitle-first">
   <asp:Label ID="lbtieude" runat="server" Text="Thông Tin"></asp:Label></div></div>
   <div style="width: 500px; height: 10px; float: left;"></div>
  <asp:Panel ID="PanelCapNhat" runat="server" >
   <div id="table_dangky">

       <table class="style1">
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td class="style7">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td class="style7">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Họ Tên :</td>
               <td class="style7">
                   <dx:ASPxTextBox ID="TxtHoTen" runat="server" NullText="Nhập Họ Tên" 
                       Theme="DevEx" Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxTextBox>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <asp:Panel ID="PNDoiMatKhau" runat="server">
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Bạn có muốn thay đổi mật khẩu không ?</td>

               <td> 
                   <asp:LinkButton ID="LinkMatKhau" CausesValidation="false" OnClick="LinkMatKhau_Click" runat="server">Đổi mật khẩu</asp:LinkButton></td>
               <td>
                   &nbsp;</td>
           </tr>
           </asp:Panel>
           <asp:Panel ID="PNTDoiMatKhau" Visible="false" runat="server">
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Bạn có muốn tắt đổi mật khẩu không ?</td>

               <td> 
                   <asp:LinkButton ID="LinkTatMatKhau" CausesValidation="false" OnClick="LinkTatMatKhau_Click" runat="server">Tắt Đổi mật khẩu</asp:LinkButton></td>
               <td>
                   &nbsp;</td>
           </tr>
           </asp:Panel>
           <asp:Panel ID="panelpass"  runat="server">
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Mật Khẩu Cũ :</td>
               <td>
                   <dx:ASPxTextBox ID="txtMatKhauCu" runat="server" Password="True" Theme="DevEx" 
                       Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxTextBox>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Mật Khẩu Mới:</td>
               <td>
                   <dx:ASPxTextBox ID="TxtMatKhauMoi" runat="server" Password="True" Theme="DevEx" 
                       Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxTextBox>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Nhập Lại Mật Khẩu Mới :<br />
                    &nbsp;</td>
               <td>
                   <dx:ASPxTextBox ID="TxtNhapLaiMatKhauMoi" runat="server" Password="True" 
                       Theme="DevEx" Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxTextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                       ControlToCompare="TxtMatKhauMoi" ControlToValidate="TxtNhapLaiMatKhauMoi" 
                       ErrorMessage="Mật Khẩu Không Trùng" ForeColor="Red"></asp:CompareValidator>
              
               </td>
               <td>
                   </td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           </asp:Panel>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Số Điện Thoại :</td>
               <td class="style7">
                   <dx:ASPxTextBox ID="TxtSoDienThoai" runat="server" MaxLength="11" 
                       NullText="Nhập Số Điện Thoại" Theme="DevEx" Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RegularExpression ErrorText="Vui Lòng Nhập Đúng Số Điện Thoại" 
                               ValidationExpression="0\d{9,11}" />
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxTextBox>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td class="style7">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Email :</td>
               <td class="style7">
                   <dx:ASPxTextBox ID="TxtEmail" runat="server" NullText="Nhập Email" 
                       Theme="DevEx" Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RegularExpression ErrorText="Vui Lòng Nhập Đúng Địa Chỉ Email" 
                               ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxTextBox>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td class="style7">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Ngày Sinh :</td>
               <td class="style7">
                   <dx:ASPxDateEdit ID="DateTimeNgaySinh" runat="server" EditFormat="Custom" 
                       EditFormatString="dd/MM/yyyy" EnableTheming="True" NullText="Nhập Ngày Sinh" 
                       Theme="DevEx" Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxDateEdit>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td class="style7">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   Địa Chỉ :</td>
               <td class="style7">
                   <dx:ASPxMemo ID="TxtDiaChi" runat="server" Height="71px" 
                       NullText="Nhập Địa Chỉ" Theme="DevEx" Width="250px">
                       <ValidationSettings ErrorText="Vui Lòng Nhập Thông Tin" CausesValidation="True">
                           <RequiredField ErrorText="Vui Lòng Nhập Thông Tin" IsRequired="True" />
                       </ValidationSettings>
                   </dx:ASPxMemo>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="style2">
                   &nbsp;</td>
               <td class="style3">
                   &nbsp;</td>
               <td class="style7">
                   &nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
       </table>

   </div>
    <div>
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    <dx:ASPxButton ID="BtnLuu" OnClick="BtnLuu_Click" runat="server" style="text-align: right" 
                        Text="Lưu Cập Nhật" Theme="DevEx" Width="200px">
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
        
    </div>
    </asp:Panel>
</asp:Content>
