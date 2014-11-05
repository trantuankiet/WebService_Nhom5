<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebNhanVien.usercontrol.Login" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v12.1, Version=12.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

      <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager" EnableScriptGlobalization="true"
                         EnableScriptLocalization="true" runat="server">
         </ajaxToolkit:ToolkitScriptManager>
          <asp:Panel ID="CDN" runat="server" Visible="true">
            <div id="checkproduct" class="regular">
     
                <asp:LinkButton ID="LinkDN" runat="server"> Đăng nhập</asp:LinkButton>
            </div>
          </asp:Panel>
          <asp:Panel ID="DNR" runat="server" Visible="false">
         <div id="checkproduct" class="regular">
     
                <asp:LinkButton ID="LinkDNR" runat="server" onclick="LinkDNR_Click"> Đăng Xuất</asp:LinkButton>
            </div>
          </asp:Panel>
        
<ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" 
   TargetControlID="LinkDN"
   PopupControlID="PanelDN"
   CancelControlID="btnthoat"
  
    runat="server">

</ajaxToolkit:ModalPopupExtender>
<asp:Panel ID="PanelDN" Style="display :none" runat="server">
<div id="FrmLogin">
                        <div id="title2">Đăng nhập</div>
                        
                        <div id="slidebar">
                        <div id="login">Tên đăng nhập :<dx:ASPxTextBox ID="txttendangnhap" runat="server" Width="170px" ValidationSettings-ErrorText="Invalid valu">
                            <ValidationSettings ErrorText="Sai Tên Đăng Nhập" 
                                ErrorTextPosition="Bottom">
                                <RequiredField ErrorText="Nhập thông tin" IsRequired="True" />
                            </ValidationSettings>
                            </dx:ASPxTextBox>
              
                         </div>  
                        <div id="login">Mật khẩu :<dx:ASPxTextBox ID="TxtMatKhau" runat="server" Width="170px" 
                                Password="True">
                                <ValidationSettings ErrorText="Sai Tên Mật Khẩu" 
                                ErrorTextPosition="Bottom">
                                <RequiredField ErrorText="Nhập thông tin" IsRequired="True" />
                            </ValidationSettings>
                            </dx:ASPxTextBox>
                         </div>
              
                        <div id="login"><center>
                        <table><tr><td> 
                            <dx:ASPxButton ID="btntendangnhap" Width="80px" Font-Size="10px" 
                                BackColor="Black" Theme="BlackGlass"   runat="server" Text="Đăng Nhập" 
                                onclick="btntendangnhap_Click">
                            </dx:ASPxButton>
                            </td>
                            <td>
                            <dx:ASPxButton ID="btnthoat" CausesValidation="false" Width="80px" Font-Size="10px" BackColor="Black" Theme="BlackGlass" runat="server" Text="Thoát">
                            </dx:ASPxButton>
                            </td>
                             </tr>
                                      </table>
                                      </center>
                                     
                        </div>
                            
                   
</div>   
</div>
</asp:Panel>
