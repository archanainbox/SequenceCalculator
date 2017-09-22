$(document).ready(function () {
    var crntVal = '', crntStore = '';
    var c, a;
    var btnVal = '';
    var operation = false;
    var method, action = '';
    var fibonacciDom = $("#FibonacciSeries");
    var fullSeriesDom = $("#AllNum");
    var evensDom = $("#evens");
    var oddsDom = $("#odds");

    var cDom = $("#c");
    var eDom = $("#e");
    var zDom = $("#z");
    
    $("#number_input").keydown(function (e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
            // Allow: Ctrl+A, Command+A
            (e.keyCode === 65 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: home, end, left, right, down, up
            (e.keyCode >= 35 && e.keyCode <= 40)) {
            // let it happen, don't do anything
            
            return;
        }
        // Ensure that it is a number and stop the keypress. Send an error message to user 
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
            alert('Please enter Positive whole Number.');
        }
    });

    $('.btnClick1 button').click(function () {
        crntStore = $('#number_input').val();
        if (crntStore > 0) { 
            calculate();
        }
        else
        {
            alert('Please enter Positive whole Number.');
        }
    });

    function calculate() {
        //full series
        var f = ResponseWrapper("api/AllNum/", crntStore);
        fullSeriesDom.text(f);

        //fibonacci
        var r = ResponseWrapper("api/fibonacciSeries/", crntStore);
        fibonacciDom.text(r);

        //even
        var evens = ResponseWrapper("api/EvenNum/", crntStore);
        evensDom.text(evens);
        //odd
        var odds = ResponseWrapper("api/OddNum/", crntStore);
        oddsDom.text(odds);

        //c
        var c = ResponseWrapper("api/COutput/", crntStore);
        cDom.text(c);

        //e
        var e = ResponseWrapper("api/EOutput/", crntStore);
        eDom.text(e);

        //z
        var z = ResponseWrapper("api/ZOutput/", crntStore);
        zDom.text(z);
        method = 0;
        return method;
    }

    function display(val) {
        val == '' ? $("input").val(crntStore) : $("input").val(val);
    }
    function ResponseWrapper(url, n) {
        var ret;
        $.ajax({
            type: "GET",
            url: url + n,
            data: {},
            success: function (response) {
                ret = response;
            },
            dataType: 'json',
            async: false
        });
        return ret;
    }  

});