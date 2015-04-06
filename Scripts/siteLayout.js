function bindDataToTable(data, table) {
    table.html("");
    var markup = "";
    markup += "<tr>";

    $.each(data[0], function (name) {

        if (data[0].hasOwnProperty(name)) {
            markup += "<th>"
              + name.replace(/([A-Z])/g, " $1") + "</th>";
        }
    });
    markup += "</tr>";
    $.each(data, function (index, value) {
        markup += "<tr>";
        $.each(value, function (propertyName, propertyValue) {
            if (value.hasOwnProperty(propertyName)) {
                markup += "<td>" + propertyValue + "</td>";
            }
        });
        markup += "</tr>";
    });
    table.append(markup);
    $("tr:nth-child(even)").addClass("oddRow");
}

function hideColumn(tableName , whichColumn) {
    $(tableName + " th:nth-child(" + whichColumn + ")").hide();
    $(tableName + " td:nth-child(" + whichColumn + ")").hide();
}

function showColumn(tableName, whichColumn) {
    $(tableName + " th:nth-child(" + whichColumn + ")").show();
    $(tableName + " td:nth-child(" + whichColumn + ")").show();
}



function getMonthIndex(value) {
    if (value < 0)
        value = 12 + value;
    return value;
}

function hideAll() {
    var index;
    for (index = 3; index <= 30; index++) {
        hideColumn("#pipelineData", index);
    }
}
function resizeColumns() {
    var index;
    for (index = 2; index <= 26; index++) {
        $("#pipelineData th:nth-child(" + index + ")").css("width", "4em");
    }

}
var months = ["Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec"];

function showVolume(count) {
    var index;
    if (typeof count == "undefined")
        count = 3;
    hideAll();
    for (index = 1; index <= count; index++) {
        showColumn("#pipelineData", (index * 2) + 2);
        hideColumn("#pipelineData", (index * 2) + 1);
    }
    resizeColumns();
}
function showUnits(count) {
    var index;
    if (typeof count == "undefined")
        count = 3;
    hideAll();
    for (index = 1; index <= count; index++) {
        showColumn("#pipelineData", (index * 2) + 1);
        hideColumn("#pipelineData", (index * 2) + 2);
    }
    resizeColumns();
}

$(document).ready(function() {
    $.ajax({
        url: "/FastFood/GetSideBar",
        type: "POST",
        success: function(result) {
            $("#sideBarList").append(result);
        }
    });

});
