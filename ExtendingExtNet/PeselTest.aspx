<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PeselTest.aspx.cs" Inherits="ExtendingExtNet.PeselTest" ViewStateMode="Disabled" %>

<%@ Register TagPrefix="okl" Namespace="ExtendingExtNet" Assembly="ExtendingExtNet" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing Pesel</title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager runat="server" />
        <okl:Pesel runat="server" ID="pesel" AutoFilledValue="Old Value" Text="Text" />
        <ext:Button runat="server" Text="Set autofill value">
            <Listeners>
                <Click Handler="pesel.setAutoFilledValue('New Value');" />
            </Listeners>
        </ext:Button>
        <ext:Button runat="server" Text="Submit">
            <DirectEvents>
                <Click OnEvent="Submit_Click" />
            </DirectEvents>
        </ext:Button>
    </form>
</body>
</html>
