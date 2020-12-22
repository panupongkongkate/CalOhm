// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#summitbutton").click(function (e) {
    var ohm = $("#ohm").val();
    var amp = $("#amp").val();
    var volt = $("#volt").val();
    if (ohm == 0) {
        $("#ohm").val(volt / amp);
    }
    if (amp == 0) {
        $("#amp").val(volt / ohm);
    }
    if (volt == 0) {
        $("#volt").val(ohm * amp);
    }
    if (ohm === 0 && amp === 0 && volt === 0) {
        resetall();
    }
    if (ohm == 0 && amp == 0 && volt == 0) {
        $("#modelId").modal();
        resetall();
    }
    if (ohm != 0 && amp != 0 && volt != 0) {
        $("#modelId").modal();
        resetall();
    }
    if (ohm == 0 && amp == 0) {
        $("#modelId").modal();
        resetall();
    }
    if (ohm == 0 && volt == 0) {
        $("#modelId").modal();
        resetall();
    }
    if (amp == 0 && volt == 0) {
        $("#modelId").modal();
        resetall();
    }
});

$("#Resetbutton").click(function (e) {
    resetall();
});

function resetall() {
    var ohm = $("#ohm").val("");
    var amp = $("#amp").val("");
    var volt = $("#volt").val("");
}