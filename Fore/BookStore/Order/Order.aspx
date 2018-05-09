<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order_Order" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="description" content=""/>
    <meta name="format-detection" content="telephone=no" />
    <meta name=""/>
    <link rel="stylesheet" href="../css/tasp.css" />
    <link href="../css/orderconfirm.css" rel="stylesheet" />

    <style>
        #page{width:auto;}
        #comm-header-inner,#content{width:950px;margin:auto;}
        #logo{padding-top:26px;padding-bottom:12px;}
        #header .wrap-box{margin-top:-67px;}
        #logo .logo{position:relative;overflow:hidden;display:inline-block;width:140px;height:35px;font-size:35px;line-height:35px;color:#f40;}
        #logo .logo .i{position:absolute;width:140px;height:35px;top:0;left:0;background:url(http://a.tbcdn.cn/tbsp/img/header/logo.png);}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page">
        <div id="content" class="grid-c">
            <div id="address" class="address" style="margin-top: 20px;" data-spm="2">
                <form name="addrForm" id="addrForm" action="#">
                    <h3>Confirmation of the receiving address<span class="manage-address">
                        <a href="http://member1.taobao.com/member/fresh/deliver_address.htm" target="_blank" title="Manage the receiving address"class="J_MakePoint" 
                        data-point-url="http://log.mmstat.com/buy.1.7">Manage the receiving address</a></span></h3>
                        <ul id="address-list" class="address-list">
                            <li class="J_Addr J_MakePoint clearfix  J_DefaultAddr "  data-point-url="http://log.mmstat.com/buy.1.20">
                                <s class="J_Marker marker"></s>
                                <span class="marker-tip">Send to</span>
                                    <div class="address-info">
                                        <a href="#" class="J_Modify modify J_MakePoint" data-point-url="http://log.mmstat.com/buy.1.21">Modify this address</a>
                                        <label for="addrId_674944241" class="user-address">
                                            London <em>18427717260</em>
                                        </label>
                                        <em class="tip" style="display: none">Default address</em>
                                        <a class="J_DefaultHandle set-default J_MakePoint" href="/auction/update_address_selected_status.htm?addrid=674944241" 
                                        style="display: none" data-point-url="http://log.mmstat.com/buy.1.18">Set to default address</a>
                                    </div></li>
                            
     </ul>
<ul id="J_MoreAddress" class="address-list hidden">
     
 </ul>

<div class="address-bar">
 <a href="#" class="new J_MakePoint" id="J_NewAddressBtn">Use a new address</a>
 </div>

</form>
</div>
 <h3 class="dib">Confirmation of order information</h3>
 <table cellspacing="0" cellpadding="0" class="order-table" id="J_OrderTable" summary="统一下单订单信息区域">
 <caption style="display: none">统一下单订单信息区域</caption>
 <thead>
 <tr>
 <th class="s-title">Shop goods<hr/></th>
 <th class="s-price">Unit Price<hr/></th>
 <th class="s-amount">Number<hr/></th>
 <th class="s-agio">Preferential approach<hr/></th>
 <th class="s-total">Subtotal<hr/></th>
 </tr>
 </thead>
     


<tbody data-spm="3" class="J_Shop" data-tbcbid="0" data-outorderid="47285539868"  data-isb2c="false" data-postMode="2" data-sellerid="1704508670">
<tr class="first"><td colspan="5"></td></tr>
<tr class="shop blue-line">
 <td colspan="2" class="promo">
 <div>
   <ul class="scrolling-promo-hint J_ScrollingPromoHint">
       </ul>
   </div>
 </td>
</tr>
 <tr class="item" data-lineid="19614514619:31175333266:35612993875" data-pointRate="0">
 <td class="s-title">
   <asp:LinkButton runat="server" ID="linkbtn" Text="华为"></asp:LinkButton>
     <%--<asp:Image runat="server" ID="img_product" ImageUrl="~/images/loc.png" CssClass="itempic" />--%>
     </a>
 <a title="消费者保障服务，卖家承诺商品如实描述" href="#" target="_blank">
<img src="http://img03.taobaocdn.com/tps/i3/T1bnR4XEBhXXcQVo..-14-16.png"/>
</a>
    <div>
 <span style="color:gray;">The seller promises to deliver within 72 hours</span>
 </div>
     </td>
 <td class="s-price">
   <asp:Label runat="server" ID="lb_price" Text="null"></asp:Label>
</td>
 <td class="s-amount" data-point-url="">
    <asp:Label runat="server" ID="lb_num" Text="1"></asp:Label>
 </td>
 <td class="s-agio">
       <div class="J_Promotion promotion" data-point-url="">No preferential treatment</div>
   </td>
 <td class="s-total">
    <asp:Label runat="server" ID="lb_allprice" Text="null"></asp:Label>
 </td>
</tr>



<tr class="item-service">
 <td colspan="5" class="servicearea" style="display: none"></td>
</tr>

<tr class="blue-line" style="height: 2px;"><td colspan="5"></td></tr>
<tr class="other other-line">
 <td colspan="5">
 <ul class="dib-wrap">
 <li class="dib user-info">
 <ul class="wrap">
 <li>
  <div class="field gbook">
   <label class="label">Leave a message to the seller:</label>
   <textarea style="width:350px;height:80px;" title="Optional: supplement to the transaction (that has been agreed and sellers are advised to fill out a note)" name=""></textarea>
 </div>
</li>
   </ul>
 </li>
 <li class="dib extra-info">

 <div class="shoparea">
 <ul class="dib-wrap">
 <li class="dib title">Store discount：</li>
 <li class="dib sel"><div class="J_ShopPromo J_Promotion promotion clearfix" data-point-url="http://log.mmstat.com/buy.1.16"></div></li>
 <li class="dib fee">  <span class='price '>
 -<em class="style-normal-bold-black J_ShopPromo_Result"  >0.00</em>
  </span>
</li>
 </ul>
 </div>

 <div class="shoppointarea"></div>

   <div class="farearea">
 <ul class="dib-wrap J_farearea">
 <li class="dib title">Transport mode：</li>
 <li class="dib sel" data-point-url="http://log.mmstat.com/jsclick?cache=*&tyxd=wlysfs">
 <input type="hidden" name="1704508670:2|actualPaidFee" value="0" class="J_ActualPaidFee" />
 <input type="hidden" name="1704508670:2|codAllowMultiple" value="true"/>
 <input type="hidden" name="1704508670:2|codSellerFareFee" value="" class="J_CodSellerFareFee"/>
 <input type="hidden" name="1704508670:2|codServiceFeeRate" value="" class="J_CodServiceFeeRate"/>
 <input type="hidden" name="1704508670:2|codPostFee" value="0" class="J_CodPostFee"/>
     </li>
 <li class="dib fee">  <span class='price '>
 <asp:Label runat="server" ID="lb_kdf" Text="30.00"></asp:Label>
  </span>
</li>
 </ul>
 </div>
   <div class="extra-area">
 <ul class="dib-wrap">
 <li class="dib title">Delivery time：</li>
 <li class="dib content">The seller committed an order within 72 hours after payment of the buyer<a href="#">Deliver goods</a></li>
 </ul>
 </div>
   
   <div class="servicearea" style="display: none"></div>
 </li>
 </ul>
 </td>
</tr>

<tr class="shop-total blue-line">
 <td colspan="5">Store together(<span class="J_Exclude" style="display: none">No</span>Freight charges<span class="J_ServiceText" style="display: none">，Service charge</span>)：
   <span class='price g_price '>
 <span></span><asp:Label runat="server" ID="lb_ppprice" Text="null"></asp:Label>
  </span>
  <input type="hidden" name="1704508670:2|creditcard" value="false" />
<input type="hidden" id="J_IsLadderGroup" name="isLadderGroup" value="false"/>

   </td>
</tr>
</tbody>
  <tfoot>
 <tr>
 <td colspan="5">

<div class="order-go" data-spm="4">
<div class="J_AddressConfirm address-confirm">
 <div class="kd-popup pop-back" style="margin-bottom: 40px;">
 <div class="box">
 <div class="bd">
 <div class="point-in">
   
   <em class="t">Real payment：</em>  <asp:Label runat="server" ID="lb_truepay" Text="null"></asp:Label>
  </span>
</div>

  <ul >
 <li><em>Send to:</em><span id="J_AddrConfirm" style="word-break: break-all;">
   London Lewis 1499237861
   </span></li>
 <li><em>Consignee:</em><span id="J_AddrNameConfirm">Lewis 1499237861 </span></li>
 </ul>
     </div>
 </div>
       <asp:ImageButton runat="server" ID="btn_buy" ImageUrl="~/images/btn_go.png" 
         onclick="btn_buy_Click" />
  </div>
 </div>

 <div class="J_confirmError confirm-error">
 <div class="msg J_shopPointError" style="display: none;"><p class="error">The integral point number must be an integer greater than 0</p></div>
 </div>


 <div class="msg" style="clear: both;">
 <p class="tips naked" style="float:right;padding-right: 0">If the price changes, please contact the seller to change the price after the order is submitted, and check the treasure that has been bought.</p>
 </div>
 </div>
 </td>
 </tr>
 </tfoot>
 </table>
</div>
  
 <input type="hidden" id="J_useSelfCarry" name="useSelfCarry" value="false" />
 <input type="hidden" id="J_selfCarryStationId" name="selfCarryStationId" value="0" />
 <input type="hidden" id="J_useMDZT" name="useMDZT" value="false" />
 <input type="hidden" name="useNewSplit" value="true" />
 <input type="hidden" id="J_sellerIds" name="allSellIds" value="1704508670" />
</form>
</div>

<div id="footer"></div>
</div>
<div style="text-align:center;">
<p>Copyright &copy; 2018<a target="_blank" href="../Index.aspx">Net BookStore</a></p>
</div>
    </form>
</body>
</html>
