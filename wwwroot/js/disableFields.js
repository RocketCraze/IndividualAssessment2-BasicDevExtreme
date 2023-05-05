function disableFields(e) {
    if (e.dataField == "ID" && e.parentType == "dataRow") {
        e.editorOptions.disabled = !e.row.isNewRow;
    }

    if (e.dataField == "ID" && e.parentType == "dataRow") {
        e.editorOptions.visible = !e.row.isNewRow;
    }
}