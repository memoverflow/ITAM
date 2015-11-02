/**
*service catalog init
*lucas ren
*/
(function () {
    var CL = function (_flowBtn, _containerArray) {
        this.flowBtn = $("#"+_flowBtn).find("button");
        this.containerArray = $("#" + _containerArray).children();
    }
    CL.prototype.initBtns = function () {
        var current = this;
        current.flowBtn.on("click", function () {
            current.containerArray.addClass("hidden");
            var index = current.flowBtn.index(this);
            $(current.containerArray[index]).removeClass("hidden");
        });

        $("#btn-submit").on("click", function () {
            $(".overlay").removeClass("hidden");
        });
        return this;
    }
   
    CL.prototype.initNavigations = function () {
        $("#service-submit").on("click", function () {
            window.location = "/home/RequestForm";
        });
    }

    var catalog = new CL("service-flow", "service-content");
    catalog.initBtns().initNavigations();
})();