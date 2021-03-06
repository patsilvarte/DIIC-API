﻿const uri = "api/beacons";
let beacons = null;
function getCount(data) {
    const el = $("#counter");
    let name = "beacon";
    if (data) {
        if (data > 1) {
            name = "beacons";
        }
        el.text(data + " " + name);
    } else {
        el.text("No " + name);
    }
}

$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#beacons");

            $(tBody).empty();

            getCount(data.length);

            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.beaconId))
                    .append($("<td></td>").text(item.name))
                    .append($("<td></td>").text(item.extraInfo))
                    .append(
                        $("<td></td>").append(
                        $("<button>Edit</button>").on("click", function () {
                            editItem(item.beaconId);
                            })
                        )
                    )
                    .append(
                        $("<td></td>").append(
                        $("<button>Delete</button>").on("click", function () {
                            deleteItem(item.beaconId);
                            })
                        )
                    );

                tr.appendTo(tBody);
            });

            beacons = data;
        }
    });
}

function addItem() {
    const item = {
        name: $("#add-name").val(),
        beaconId: $("#add-beacon-id").val(),
        extraInfo: $("#add-extra-info").val()

    };

    $.ajax({
        type: "POST",
        accepts: "application/json",
        url: uri,
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
            name: $("#add-name").val("");
            beaconId: $("#add-beacon-id").val("");
            extraInfo: $("#add-extra-info").val("");
        }
    });
}

function deleteItem(beaconId) {
    $.ajax({
        url: uri + "/" + beaconId,
        type: "DELETE",
        success: function (result) {
            getData();
        }
    });
}

function editItem(beaconId) {
    $.each(beacons, function (key, item) {
        if (item.beaconId === beaconId) {
            $("#edit-name").val(item.name);
            $("#edit-id").val(item.id);
            $("#edit-extra-info").val(item.extraInfo);
            $("#edit-beacon-id").val(item.beaconId);
        }
    });
    $("#spoiler").css({ display: "block" });
}

$(".my-form").on("submit", function () {
    const item = {
        id: $("#edit-id").val(),
        beaconId: $("#edit-beacon-id").val(),
        name: $("#edit-name").val(),
        extraInfo: $("#edit-extra-info").val()
        
    };

    $.ajax({
        url: uri + "/" + $("#edit-beacon-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        success: function (result) {
            getData();
        }
    });

    closeInput();
    return false;
});

function closeInput() {
    $("#spoiler").css({ display: "none" });
}