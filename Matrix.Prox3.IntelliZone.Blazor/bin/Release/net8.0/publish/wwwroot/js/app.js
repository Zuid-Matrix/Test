async function downloadFileFromStream(fileName, contentStreamReference) {
   // const arrayBuffer = await contentStreamReference.arrayBuffer();
    var enc = new TextEncoder();
    const arrayBuffer = enc.encode(contentStreamReference);
    const blob = new Blob([arrayBuffer]);

    const url = URL.createObjectURL(blob);

    triggerFileDownload(fileName, url);

    URL.revokeObjectURL(url);
}

function triggerFileDownload(fileName, url) {
    const anchorElement = document.createElement("a");
    anchorElement.href = url;

    if (fileName) {
        anchorElement.download = fileName;
    }

    anchorElement.click();
    anchorElement.remove();
}
function BlazorDownloadFile(filename, content) {
    // thanks to Geral Barre : https://www.meziantou.net/generating-and-downloading-a-file-in-a-blazor-webassembly-application.htm 

    // Create the URL
    const file = new File([content], filename, { type: "application/octet-stream" });
    const exportUrl = URL.createObjectURL(file);

    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = exportUrl;
    a.download = filename;
    a.target = "_self";
    a.click();

    // We don't need to keep the object url, let's release the memory
    // On Safari it seems you need to comment this line... (please let me know if you know why)
    URL.revokeObjectURL(exportUrl);
}

async function BlazorDownloadFile2(filename, content) {
    // thanks to Geral Barre : https://www.meziantou.net/generating-and-downloading-a-file-in-a-blazor-webassembly-application.htm

    // Create the URL
    const file = new File([content], filename, { type: "application/octet-stream" });
    const url = URL.createObjectURL(file);


    triggerExcelFileDownload(fileName, url);

    // We don't need to keep the object url, let's release the memory
    // On Safari it seems you need to comment this line... (please let me know if you know why)
    URL.revokeObjectURL(url);
}


function triggerExcelFileDownload(filename, url) {
    // Create the <a> element and click on it
    const a = document.createElement("a");
    document.body.appendChild(a);
    a.href = url;
    a.download = filename;
    a.target = "_self";
    a.click();
    a.remove();
}

