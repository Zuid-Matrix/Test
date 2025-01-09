//window.saveAsXLSFile = function (fileName, linkBase64) {
//    var link = this.document.createElement('a');
//    link.download = fileName;
//    link.href = linkBase64;
//    this.document.body.appendChild(link);
//    link.click();
//    this.document.body.removeChild(link);
//}

//window.saveAsPDF = async function(pdfPath) {
//    const response = await fetch(pdfPath, { method: 'POST' });

//    if (respons.ok) {
//        const blob = await response.blob();
//        const url = URL.createObjectURL(blob);
//        const a = document.createElement('a');
//        a.href = url;
//        a.download = 'export.pdf';
//        document.body.appendChild(a);
//        a.click();
//        document.body.removeChild(a);
//        URL.revokeObjectURL(url);
//    }
//}

//window.DownloadRazorPdf = async function (reportvar) {
//    const link = document.createElement('a');
//    link.href = "/DownloadPdf?pageName=PdfView&reportdata="+reportvar;
//    link.target = "_blank";
//    document.body.appendChild(link);
//    link.click();
//    document.body.removeChild(link);
//}

//window.DownloadPdfView = async function (reportvar) {
//    const link = document.createElement('a');
//    link.href = "/DownloadPdf?pageName=PdfView&reportdata=" + reportvar;
//    link.target = "_blank";
//    document.body.appendChild(link);
//    link.click();
//    document.body.removeChild(link);
//}

//function SaveAll() {
//    DotNet.invokeMethodAsync('ProxLocalConnections.Server', 'SaveLinks');
//};
