function disableId(e) {
    if (e.dataField == "ID" && e.parentType == "dataRow") {
        e.editorOptions.disabled = !e.row.isNewRow;
    }

    //if (e.dataField != "EmpId" && e.parentType == "dataRow") {
    //    e.editorOptions.disabled = (typeof e.row.data.EmpId !== "number");
    //}
}

function setCellValueQualifications(newData, value) {
    this.defaultSetCellValue(newData, value);
}