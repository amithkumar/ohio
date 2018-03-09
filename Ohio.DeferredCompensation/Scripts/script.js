$(document).ready(function () {
    //click body
    var showError = function (errorText) {
        alert(errorText);
    }
    var ajaxSubmit = function (form, successHandler) {
        form.ajaxSubmit({
            success: function (response) {
                if (response.success) {
                    if (successHandler) {
                        successHandler(response);
                    }
                }
                else {
                    showError(response.responseText);
                }
            }
        });
    }

    // scroll to top on cancel/next/previous step
    $(".btn-next,\
       .btn-next-step,\
       .btn-cancel,\
       .btn-previous-step").click(function () {
        window.scrollTo(0, 0);
    });

    function hiddenAllPopup() {
        $("header .cover-header .right-header .list-title li .popup-contact").addClass("hide");
        $("header .cover-header .right-header .box-seach .detail-seach").addClass("hide");
        $(".top-identify-id .left-group").removeClass("active");
        $(".top-identify-manager .left-group").removeClass("active");
        $(".top-identify-manager").removeClass("fix-zindex");
        $(".top-identify-id").removeClass("fix-zindex");
        $(".container-fluid").removeClass("move-right");
        $(".header-mobi .right-header .popup-contact").addClass("hide");
        $(".select-tab").removeClass("open-select");
        $(".container-fluid").removeClass("show-intructions");
        $(".file-manager .top-identify-manager .left-group").removeClass("active");
        $(".header-mobi .mobi-seach").addClass("hide");
        $(".dark-overlay").addClass("hide");
    }
    $("body").click(function (event) {
        hiddenAllPopup();
    })

    $(".ddown-select").selectmenu();

    $(".datepicker-birth").datepicker({
        dateFormat: "mm/dd/yy",
        showOtherMonths: true
    });

    // custom scroll dropdow
    $(".box-instructions .group-para").mCustomScrollbar({
        theme: "dark",
        scrollInertia: 400
    });

    $(".ddown-select").selectmenu();

    //click header contact us
    $("header .cover-header .right-header .list-title li .click-me").click(function (event) {
        event.stopPropagation();
        if ($("header .cover-header .right-header .list-title li .popup-contact").hasClass("hide")) {
            hiddenAllPopup();
            $("header .cover-header .right-header .list-title li .popup-contact").removeClass("hide");
            $(".dark-overlay").removeClass("hide");
        } else {
            hiddenAllPopup();
        }
    })

    $("header .cover-header .right-header .list-title li .popup-contact .click-close").on("click", function () {
        hiddenAllPopup();
    })

    $("header .cover-header .right-header .list-title li .popup-contact").on("click", function (event) {
        event.stopPropagation();
    })

    //click menu header mobi
    $(".header-mobi .left-header .click-menu").click(function (event) {
        event.stopPropagation();
        if ($(".container-fluid").hasClass("move-right")) {
            $(".container-fluid").removeClass("move-right");
        } else {
            $(".container-fluid").addClass("move-right");
        }
    })

    $(".mobi-navigation").click(function (event) {
        event.stopPropagation();
    })

    $(".mobi-navigation .list-menu li a").click(function (event) {
        event.stopPropagation();
        if ($(this).text() !== "Home") {
            if ($(this).parent().parent().hasClass("active")) {
                $(this).parent().parent().removeClass("active");
            } else {
                $(this).parent().parent().addClass("active");
            }
        }
    })

    //click search header mobi
    $(".header-mobi .right-header .click-seach").click(function (event) {
        event.stopPropagation();
        if ($(".header-mobi .mobi-seach").hasClass("hide")) {
            hiddenAllPopup();
            $(".header-mobi .mobi-seach").removeClass("hide");
            $(".dark-overlay").removeClass("hide");
        } else {
            hiddenAllPopup();
        }
    })

    $(".mobi-seach").click(function (e) {
        e.stopPropagation();
    });
    $(".mobi-seach .click-go").click(function (e) {
        hiddenAllPopup();
    });
    $(".detail-seach .click-go").click(function (e) {
        hiddenAllPopup();
    });

    $(".header-mobi .right-header .click-phone").click(function (event) {
        event.stopPropagation();
        if ($(".header-mobi .right-header .popup-contact").hasClass("hide")) {
            hiddenAllPopup();
            $(".header-mobi .right-header .popup-contact").removeClass("hide");
            $(".dark-overlay").removeClass("hide");
        } else {
            hiddenAllPopup();
        }
    })

    $(".header-mobi .right-header .popup-contact .click-close").click(function () {
        hiddenAllPopup();
    })

    //click search
    $("header .cover-header .right-header .box-seach .click-seach").on("click", function (event) {
        event.stopPropagation();
        if ($("header .cover-header .right-header .box-seach .detail-seach").hasClass("hide")) {
            hiddenAllPopup();
            $("header .cover-header .right-header .box-seach .detail-seach").removeClass("hide");
            $(".dark-overlay").removeClass("hide");
        } else {
            hiddenAllPopup();
        }
    })

    $("header .cover-header .right-header .box-seach .detail-seach").on("click", function (event) {
        event.stopPropagation();
    })

    $(".noti-arlet .click-close").click(function () {
        $(this).closest(".noti-arlet").removeClass("show-arlet");
    });

    //scroll top
    function scrollTopPage() {
        $(window).scrollTop(0);
    }
    setHeightFunc();
    //set height page
    function setHeightFunc() {
        $(".all-page").css("height", "auto");
        var heightWindow = $(window).height();
        var heightPage = $(".all-page").height();
        var heightNav = $(".mobi-navigation").height();
        if (heightPage < heightWindow - 331) {
            $(".all-page").css("height", heightWindow - 331 + "px");
        }
        $(".mobi-navigation").css("height", $(".row").height() + "px");
    }
    // validate input
    function validateInput(cls) {
        var checked = false;
        $("." + cls + " input").each(function () {
            if ($(this).val() === "") {
                $(this).parent().addClass("error-ver");
                checked = true;
            }
        });

        //validate input email
        var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
        $("." + cls + " input.txt-email").each(function () {
            if ($(this).val() === "" || !testEmail.test(this.value)) {
                $(this).parent().addClass("error-ver");
                checked = true;
            }
        });
        return checked;
    }

    // clear error
    $("input").focus(function () {
        $(this).parent().removeClass("error-ver");
    });
    //Pie Chart
    function drawPieChart() {
        d3.selectAll(".pie-chart svg").remove();
        var pie = d3.pie()
            .value(function (d) {
                return d.percent
            })
            .sort(null)
            .padAngle(.03);

        var arc = d3.arc()
            .outerRadius(outerRadius)
            .innerRadius(innerRadius);

        var svg = d3.selectAll(".pie-chart").append("svg")
            .attr("width", w)
            .attr("height", h)
            .attr("class", "shadow")
            .append("g")
            .attr("transform", "translate(" + w / 2 + "," + h / 2 + ")");

        var path = svg.selectAll("path")
            .data(pie(dataset))
            .enter()
            .append("path")
            .attr("d", arc)
            .attr("fill", function (d, i) {
                return color(d.data.name);
            });

        svg.append("text")
            .attr("text-anchor", "middle")
            .attr('font-size', function () {
                if ($(window).width() <= 768) {
                    return "11px";
                }
                return "16px";
            })
            .attr('font-weight', '500')
            .attr("fill", "#4e4e4e")
            .attr('y', 0)
            .text(textChartTop);

        svg.append("text")
            .attr("text-anchor", "middle")
            .attr('font-size', function () {
                if ($(window).width() <= 768) {
                    return "11px";
                }
                return "14px";
            })
            .attr('font-weight', function () {
                if ($(window).width() <= 768) {
                    return 500;
                }
                return "normal";
            })
            .attr("fill", "#4e4e4e")
            .attr('y', 15)
            .text(textChartBottom);

        path.transition()
            .duration(1000)
            .attrTween("d", function (d) {
                var interpolate = d3.interpolate({
                    startAngle: 0,
                    endAngle: 0
                }, d);
                return function (t) {
                    return arc(interpolate(t));
                };
            });
    }

    //Dynamic Pie Chart in Fund Exchange Request page
    function drawPieChartDynamic() {
        d3.selectAll(".pie-chart-dynamic svg").remove();
        var pie = d3.pie()
            .value(function (d) {
                return d.percent
            })
            .sort(null)
            .padAngle(.03);

        var arc = d3.arc()
            .outerRadius(outerRadius)
            .innerRadius(innerRadius);

        var svg = d3.selectAll(".pie-chart-dynamic").append("svg")
            .attr("width", w)
            .attr("height", h)
            .attr("class", "shadow")
            .append("g")
            .attr("transform", "translate(" + w / 2 + "," + h / 2 + ")");

        var path = svg.selectAll("path")
            .data(pie(datasetDynamic))
            .enter()
            .append("path")
            .attr("d", arc)
            .attr("fill", function (d, i) {
                return color(d.data.name);
            });

        svg.append("text")
            .attr("text-anchor", "middle")
            .attr('font-size', function () {
                if ($(window).width() <= 768) {
                    return "11px";
                }
                return "16px";
            })
            .attr('font-weight', '500')
            .attr("fill", "#4e4e4e")
            .attr('y', 0)
            .text(textChartTop);

        svg.append("text")
            .attr("text-anchor", "middle")
            .attr('font-size', function () {
                if ($(window).width() <= 768) {
                    return "11px";
                }
                return "14px";
            })
            .attr('font-weight', function () {
                if ($(window).width() <= 768) {
                    return 500;
                }
                return "normal";
            })
            .attr("fill", "#4e4e4e")
            .attr('y', 15)
            .text(textChartBottom);

        path.transition()
            .duration(1000)
            .attrTween("d", function (d) {
                var interpolate = d3.interpolate({
                    startAngle: 0,
                    endAngle: 0
                }, d);
                return function (t) {
                    return arc(interpolate(t));
                };
            });
    }

    //Line Chart
    function drawLineChart() {
        d3.select(".line-chart svg").remove();
        var margin = {
            top: 40,
            right: 40,
            bottom: 40,
            left: 80
        };
        var width = 574 - margin.left - margin.right;
        var height = 400 - margin.top - margin.bottom;

        if ($(window).width() <= 768) {
            margin = {
                top: 40,
                right: 40,
                bottom: 40,
                left: 40
            }
            width = $(window).width() - margin.left - margin.right;
            height = 280 - margin.top - margin.bottom;
        }

        var svg = d3.select(".line-chart").append("svg")
            .attr("width", width + margin.left + margin.right)
            .attr("height", height + margin.top + margin.bottom)
            .style("margin", "0 auto")
            .style("display", "block");

        var g = svg.append("g").attr("transform", "translate(" + margin.left + "," + margin.top + ")");

        var formatValue = d3.format(".0s");
        var formatTime = d3.timeFormat("%b");
        var x = d3.scaleTime().rangeRound([0, width]);

        var y = d3.scaleLinear().range([height, 0]);

        var xAxis = d3.axisBottom(x).tickSizeInner(-height).tickSizeOuter(0).tickFormat(formatTime);

        var yAxis = d3.axisLeft(y).ticks(5).tickSizeOuter(0).tickSizeInner(-width).tickFormat(formatValue);

        dataSelect.forEach(function (d) {
            d.year = new Date(d.year)
            d.value = d.value;
        });
        x.domain([d3.min(dataSelect, function (d) {
            return d.year;
        }), d3.max(dataSelect, function (d) {
            return d.year;
        })]);

        y.domain([0, d3.max(dataSelect, function (d) {
            return Math.pow(10, d.value.toString().length) % d.value + d.value;
        })]);

        g.append("g")
            .attr("class", "x axis")
            .attr("transform", "translate(0," + height + ")")
            .call(customXAxis)
            .selectAll("text")
            .style("text-anchor", "middle")
            .style("fill", "rgba(0, 0, 0, 0.7)")
            .style("font-size", function () {
                if ($(window).width() <= 768) {
                    return "10px";
                }
                return "16px";
            })
            .style("font-weight", "bold")
            .attr("x", 0)
            .attr("y", 24)
            .attr("dy", 0)
            .attr("transform", "rotate(0)");

        g.append("g")
            .attr("class", "y axis")
            .call(customYAxis);

        var line = d3.line()
            .curve(d3.curveCardinal)
            .x(function (d) {
                return x(d.year);
            })
            .y(function (d) {
                return y(d.value);
            });

        var path = g.append("path")
            .data(dataSelect)
            .attr("d", line(dataSelect))
            .attr("x", "2em")
            .attr("stroke-width", 4)
            .style("stroke", "#3c9edb")
            .attr("fill", "none")
            .attr("height", function (d) {
                return height - y(d.value);
            });
        var totalLength = path.node().getTotalLength();
        path.attr("stroke-dasharray", totalLength + " " + totalLength)
            .attr("stroke-dashoffset", totalLength)
            .transition()
            .duration(2000)
            .ease(d3.easeLinear)
            .attr("stroke-dashoffset", 0);

        var circle = g.selectAll(".dot")
            .data(dataSelect)
            .enter()
            .append("circle")
            .style("fill", "#fff")
            .attr("class", "dot")
            .attr("stroke", "#3c9edb")
            .attr("stroke-width", 4)
            .attr("cx", line.x())
            .attr("cy", line.y())
            .attr("r", 7);

        circle.transition()
            .duration(4000);

        function customXAxis(gTemp) {
            gTemp.call(xAxis);
            gTemp.selectAll(".axis .tick text").attr("y", 10);
            gTemp.selectAll(".axis .tick line").attr("stroke", "#b2b2b2");
            gTemp.selectAll(".axis path").attr("stroke", "#eaeaea");
            if ($(window).width() <= 768) {
                gTemp.selectAll(".axis .tick text").attr("font-size", "10px");
            }
        }

        function customYAxis(gTemp) {
            gTemp.call(yAxis);
            gTemp.selectAll(".axis .tick text").attr("x", -15);
            gTemp.selectAll(".axis .tick text").attr("font-size", "16px");
            gTemp.selectAll(".axis .tick text").attr("font-weight", "bold");
            gTemp.selectAll(".axis .tick text").attr("fill", "rgba(0, 0, 0, 0.7)");
            gTemp.selectAll(".axis .tick text").attr("display", "block");
            gTemp.selectAll(".axis path").attr("stroke", "#eaeaea");
            gTemp.selectAll(".axis .tick line").attr("stroke", "#b2b2b2");
            if ($(window).width() <= 768) {
                gTemp.selectAll(".axis .tick text").attr("font-size", "10px");
            }
        }
    }

    // common compare function
    function comparer(index) {
        return function (a, b) {
            var valA = getCellValue(a, index),
                valB = getCellValue(b, index);
            return $.isNumeric(valA) && $.isNumeric(valB) ?
                valA - valB : valA.localeCompare(valB);
        };
    }

    function getCellValue(row, index) {
        return $(row).children('div').eq(index).text();
    }

    // ==== click show tooltip mobile===
    $(".click-intructions").click(function (event) {
        event.stopPropagation();
        $(".container-fluid").addClass("show-intructions");
    })

    $(".box-instructions").click(function (event) {
        event.stopPropagation();
    })

    $(".box-instructions .close-intructions").click(function (event) {
        $(".container-fluid").removeClass("show-intructions");
    })

    //click dropdown view account
    $(".top-identify-manager .left-group .cover-all-v02 .top-group .btn-view").on("click", function (event) {
        event.stopPropagation();
        if ($(".top-identify-manager .left-group").hasClass("active")) {
            hiddenAllPopup();
        } else {
            hiddenAllPopup();
            $(".top-identify-manager .left-group").addClass("active");
            $(".dark-overlay").removeClass("hide");
            $(".top-identify-manager").addClass("fix-zindex");
        }
    });

    //click dropdown view account id
    $(".top-identify-id .left-group .cover-all-v02 .top-group .red-id").on("click", function (event) {
        event.stopPropagation();
        if ($(".top-identify-id .left-group").hasClass("active")) {
            hiddenAllPopup();
        } else {
            hiddenAllPopup();
            $(".top-identify-id .left-group").addClass("active");
            $(".dark-overlay").removeClass("hide");
            $(".top-identify-id").addClass("fix-zindex");
        }
    })

    // input Only number
    $(".number-only").keydown(function (e) {
        // Allow: backspace, delete, tab, escape, enter and .
        if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
            // Allow: Ctrl+A, Command+A
            (e.keyCode === 65 && (e.ctrlKey === true || e.metaKey === true)) ||
            // Allow: home, end, left, right, down, up
            (e.keyCode >= 35 && e.keyCode <= 40)) {
            // let it happen, don't do anything
            return;
        }
        // Ensure that it is a number and stop the keypress
        if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
            e.preventDefault();
        }
    });

    //============== Landing Page =============
    if ($(".landing-page").length) {
        setTimeout(function () {
            $(".noti-arlet").addClass("show-arlet");
        }, 500);
        //Slick slider
        $(".top-landing").slick({
            autoplay: false,
            arrows: false,
            dots: true,
            infinite: true,
            speed: 300,
            slidesToShow: 1,
            slidesToScroll: 1,
            responsive: [
                {
                    breakpoint: 1023,
                    settings: {
                        dots: false
                    }
                },
                {
                    breakpoint: 667,
                    settings: {
                        dots: false
                    }
                }
            ]
        });

        $(".mobi-login .tab-select .select-tab").click(function () {
            $(".mobi-login .tab-content").addClass("hide");
            $(".mobi-login .tab-select .select-tab").removeClass("active");
            if ($(this).text().trim() === "Login") {
                $(".mobi-login .tab-login").removeClass("hide");
                $(this).addClass("active");
            } else if ($(this).text().trim() === "Signup") {
                $(".mobi-login .tab-signup").removeClass("hide");
                $(this).addClass("active");
            }
        });
    }
    //============== Retrieve Page ============
    if ($(".retreive-page-content").length) {
        var step = 1;
        // next step function
        $(".step-content .btn-next-step").click(function () {
            if (!validateInput("step-more-details .step-content:nth-child(" + step + ")")) {
                if (step === 1) {
                    var form = $('#retrieve-form-step1');
                    ajaxSubmit(form, function (response) {
                        nextStep();
                        var username = response.content.userId;
                        $('.step-two-content .bold-name').text(username);
                        $('.step-three-content input[name="Username"]').val(username);
                        $('.step-three-content .user-email').text(response.content.email);
                        $('.step-three-content .user-mobile').text(response.content.phone);

                    });
                }
                else if (step === 3) {
                    var form = $('#retrieve-form-step3');
                    ajaxSubmit(form, function (response) {
                        nextStep();
                    });
                }
                else if (step === 4) {
                    var form = $('#retrieve-form-step4');
                    ajaxSubmit(form, function (response) {
                        var accessCode = response.content.accessCode;
                        $('.step-five-content input[name="AccessCode"]').val(accessCode);
                        nextStep();
                    });
                }
                else {
                    nextStep();
                }
            }
        });

        // handle click on Try Again in Step 4
        $(".step-four-content .try-again").click(function () {
            var form = $('#retrieve-form-step3');
            ajaxSubmit(form, function (response) {
                // notify user that code is sent if needed
            });
        });

        $(".step-content .btn-success").click(function () {
            if (!validateInput("step-more-details .step-content:nth-child(5)")) {
                var form = $('#retrieve-form-step5');
                ajaxSubmit(form, function (response) {                    
                   // window.location.href = $('.step-five-content').data('redirect-url');
                });
            }
        });

        //datepicker
        $(".datepicker-birth").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true
        });

        function nextStep() {
            scrollTopPage();
            resetClsStep();
            step++;
            for (let i = 1; i < step; i++) {
                $(".step-by-step .nested-circle ul li:nth-child(" + i + ")").addClass("done");
            }
            $(".step-by-step .nested-circle ul li:nth-child(" + step + ")").addClass("current");

            $(".step-more-details .step-content").addClass("hide");
            $(".step-more-details .step-content:nth-child(" + step + ")").removeClass("hide");
        }

        function resetClsStep() {
            $(".step-by-step .nested-circle ul li").removeClass("done");
            $(".step-by-step .nested-circle ul li").removeClass("current");
        }
    }
    //============== Sign up Pagge ============
    if ($(".signup-page").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-one-content")) {
                $(".step-more-details .step-content").addClass("hide");
                $(".step-by-step .nested-circle ul .step01").addClass("done");
                $(".step-by-step .nested-circle ul .step02").addClass("current");
                $(".step-more-details .step-two-content").removeClass("hide");
            }
        });

        //Step 2
        $(".step-more-details .step-two-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("validate-step2")) {
                ajaxSubmit($(this).closest('form'), function () {
                    $(".step-more-details .step-content").addClass("hide");
                    $(".step-by-step .nested-circle ul .step02").addClass("done");
                    $(".step-by-step .nested-circle ul .step03").addClass("current");
                    $(".step-more-details .step-three-content").removeClass("hide");
                });
            }
        });

        //datepicker
        $(".datepicker-birth").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true
        });
    }
    //============== About us =================
    if ($(".about-us-page").length) {
        //click tab content
        $(".primary-content .select-tab .simply-tab").on("click", function (event) {
            $(".primary-content .select-tab .simply-tab").removeClass("active");
            $(".primary-content .tab-content").addClass("hide");
            if ($(event.currentTarget).text().trim() === "About Ohio DC") {
                $(".primary-content .select-tab .simply-tab.order01").addClass("active");
                $(".primary-content .tab-order01-content").removeClass("hide");
            } else if ($(event.currentTarget).text().trim() === "Board Members") {
                $(".primary-content .select-tab .simply-tab.order02").addClass("active");
                $(".primary-content .tab-order02-content").removeClass("hide");
            } else if ($(event.currentTarget).text().trim() === "Services") {
                $(".primary-content .select-tab .simply-tab.order03").addClass("active");
                $(".primary-content .tab-order03-content").removeClass("hide");
            }
        });

        //click tab version mobile
        $(".select-tab .click-select").click(function (event) {
            event.stopPropagation();
            $(this).parent().addClass("open-select");
        });
        $(".select-tab .list-tab li.active .list-title").click(function (event) {
            event.stopPropagation();
            $(this).parent().parent().parent().removeClass("open-select");
        })

        $(".select-tab .list-tab").click(function (event) {
            event.stopPropagation();
        })

        $(".select-tab .list-tab li .list-title").click(function (event) {
            event.stopPropagation();
            $(".tab-content").addClass("hide");
            if ($(this).text().trim() === "About Ohio DC") {
                $(".tab-order01-content").removeClass("hide");
            } else if ($(this).text().trim() === "Our Board Members") {
                $(".tab-order02-content").removeClass("hide");
            } else if ($(this).text().trim() === "Our Services") {
                $(".tab-order03-content").removeClass("hide");
            }
            $(".select-tab .click-select .title-tab").text($(this).text().trim());
            $(".select-tab .list-tab li.active").before($(this).parent());
            $(".select-tab .list-tab li").removeClass("active");
            $(this).parent().addClass("active");
            $(this).parent().parent().parent().removeClass("open-select");
        });
    }
    //============== Calculator Page ==========
    if ($(".calculator").length) {

    }
    //============== Calculator Funding Page ===============
    if ($(".college-funding").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            var form = $(this).closest('form');
            if (form.valid()) {
                ajaxSubmit(form, function (response) {
                    // set results in step 2
                    var data = response.content;
                    $('.step-two-content .total-college-costs').text(data.totalCollegeCosts);
                    $('.step-two-content .college-savings-need').text(data.collegeSavingsNeed);
                    $('.step-two-content .amount-provided').text(data.amountProvided);
                    $('.step-two-content .savings-per-month').text(data.savingsPerMonth);
                    $('.step-two-content .lump-sum-savings-need').text(data.lumpSumSavingsNeed);

                    $(".step-more-details .step-content").addClass("hide");
                    $(".step-by-step .nested-circle ul .step01").addClass("done");
                    $(".step-by-step .nested-circle ul .step02").addClass("current");
                    $(".step-more-details .step-two-content").removeClass("hide");
                });
            }
        });

        //prev step
        $(".step-more-details .step-two-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").removeClass("done");
            $(".step-by-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-one-content").removeClass("hide");
        });
    }

    //============== Edit personal info Page ===============

    if ($(".edit-personal-info").length) {
        //next step
        //Step 1
        $("#sel-retire").selectmenu({
            change: function (event, ui) {
                if ($("#sel-retire option:selected").text() !== "Select") {
                    $("#sel-retire-button").css("border", "none");
                }
            }
        });

        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-more-details .step-one-content")) {
                var form = $(this).closest('form');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        $(".step-more-details .step-content").addClass("hide");
                        $(".step-by-step .nested-circle ul .step01").addClass("done");
                        $(".step-by-step .nested-circle ul .step02").addClass("current");
                        $(".step-more-details .step-four-content").removeClass("hide");
                    });
                }
            }
        });

        //prev step
        $(".step-more-details .step-two-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").removeClass("done");
            $(".step-by-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-one-content").removeClass("hide");
        });

        // E-Delivery Preferences
        $('.quarterly-statement input[name="QuarterlyStatementAndFocusNewsLetter"]').change(function () {
            var form = $(this).closest('form');
            if (form.valid()) {
                ajaxSubmit(form);
            }
        });
    }


    //============== Edit Account contribution Page ===============

    //next step
    //Step 1
    $("#acc-con-edit-btn").on("click", function () {
        if (!validateInput("step-more-details .step-one-content")) {
            $(".group-quarterly .each-tab-details .order01").addClass("hide");
            $(".group-quarterly .each-tab-details .order02").removeClass("hide");
            $(".complex-table01").addClass("hide");
            $(".complex-table02").removeClass("hide");
            $("#account-contribution-tab2").addClass("active");
            $("#account-contribution-tab1").removeClass("active");

        }
    });
    $("#account-contribution-tab2").on("click", function () {
        if (!validateInput("step-more-details .step-one-content")) {
            $(".group-quarterly .each-tab-details .order01").addClass("hide");
            $(".group-quarterly .each-tab-details .order02").removeClass("hide");
            $(".complex-table01").addClass("hide");
            $(".complex-table02").removeClass("hide");
            $("#account-contribution-tab2").addClass("active");
            $("#account-contribution-tab1").removeClass("active");

        }
    });
    $("#account-contribution-tab1").on("click", function () {
        if (!validateInput("step-more-details .step-one-content")) {
            $(".group-quarterly .each-tab-details .order01").removeClass("hide");
            $(".group-quarterly .each-tab-details .order02").addClass("hide");
            $(".complex-table01").removeClass("hide");
            $(".complex-table02").addClass("hide");
            $("#account-contribution-tab2").removeClass("active");
            $("#account-contribution-tab1").addClass("active");

        }
    });


    //============== Account contribution edit Page ===============
    if ($(".contribution-content").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-more-details .step-one-content")) {
                $(".step-more-details .step-content").addClass("hide");
                $(".step-by-step .nested-circle ul .step01").addClass("done");
                $(".step-by-step .nested-circle ul .step02").addClass("current");
                $(".step-more-details .step-four-content").removeClass("hide");
            }
        });

    }
    if ($(".account-contribution-edit").length) {
        var constructContributionModel = function () {
            var stockGroups = [];
            $('.stock-group').each(function (ind, el) {
                var stocks = [];
                $('input[name="alloAmount"]', $(el)).each(function (index, stockEl) {
                    stocks.push({
                        FundName: $(stockEl).data('fund-name'),
                        NewAllocationAmount: $(stockEl).val()
                    });
                });
                stockGroups.push({
                    GroupName: $(el).data('stock-group'),
                    Stocks: stocks
                });
            });

            var model = {
                NewDeferralAmount: $('input[name="NewDeferralAmount"]').val(),
                AllocationOption: $('input[name="AllocationOption"]:checked').val(),
                StockGroups: stockGroups
            };
            return model;
        };

        //next step
        //Step 1
        $("#acc-con-step1-next").on("click", function () {
            if (!validateInput("step-more-details .step-one-content")) {
                // create and submit data
                var model = constructContributionModel();
                $.ajax({
                    url: '/Account/EditContributionPreview',
                    type: 'POST',
                    contentType: 'application/json',
                    data: JSON.stringify(model),
                    success: function (result) {
                        var reviewDiv = $('#edit-review-form');
                        reviewDiv.replaceWith(result);
                        $(".step-more-details .step-one-content").addClass("hide");
                        $(".box-step .nested-circle ul .step01").addClass("done");
                        $(".box-step .nested-circle ul .step02").addClass("current");
                        $(".step-more-details .step-two-content").removeClass("hide");
                    }
                });
            }
        });

        //Step 2
        $("#acc-con-step2-next").on("click", function () {
            var model = constructContributionModel();
            $.ajax({
                url: '/Account/EditContribution',
                type: 'POST',
                contentType: 'application/json',
                data: JSON.stringify(model),
                success: function (response) {
                    if (response.success) {
                        $(".step-more-details .step-two-content").addClass("hide");
                        $(".box-step .nested-circle ul .step01").addClass("done");
                        $(".box-step .nested-circle ul .step02").addClass("done");
                        $(".step-more-details .step-four-content").removeClass("hide");
                    }
                    else {
                        showError(response.responseText);
                    }
                }
            });
        });
        //Step 2 prv
        $("#acc-con-step2-prv").on("click", function () {
            $(".step-more-details .step-one-content").removeClass("hide");
            $(".box-step .nested-circle ul .step01").removeClass("done");
            $(".box-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-two-content").addClass("hide");
        });

        var updateTotalAllocationAmount = function () {
            var sum = 0;
            $('.step-one-content input[name="alloAmount"]').each(function (ind, el) {
                var val = $(el).val();
                if (val.length && !isNaN(val)) {
                    sum += parseFloat(val);
                }
            });
            var isDollar = $('input[name="AllocationOption"]:checked').val() === 'Dollar';
            if (isDollar) {
                sum = '$' + sum;
            }
            else {
                sum += '%';
            }
            $('#total-value').text(sum);
        };

        var updateSign = function () {
            var isDollar = $('input[name="AllocationOption"]:checked').val() === 'Dollar';
            if (isDollar) {
                $('.step-one-content .dollar-sign').show();
                $('.step-one-content .percentage-sign').hide();
            }
            else {
                $('.step-one-content .dollar-sign').hide();
                $('.step-one-content .percentage-sign').show();
            }
            updateTotalAllocationAmount();
        };

        $('input[name="AllocationOption"]').change(updateSign);
        $('input[name="alloAmount"]').change(updateSign);
        updateSign();
    }
    // ===================== Transaction history Filter ============
    if ($(".transaction-history").length) {
        $("#filter-desktop-btn").on("click", function () {
            $("#filter-desktop-pnl").toggleClass("hide");
        });

        $("#filter-close-btn").on("click", function () {
            $("#filter-desktop-pnl").addClass("hide");
        });
        $(".datepicker-birth").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true
        });
        $(".btn-clear").on("click", function () {
            $("input[name='FilterStartDate'").val(null);
            $("input[name='FilterEndDate'").val(null);
        });
    }
    //============== Change Password ===============
    if ($(".change-password-phone").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-more-details .step-one-content")) {
                $("#conf-password-err").addClass("hide");
                $("#conf-password").removeClass("red-icon");
                if ($("#new-password").val() === $("#conf-password").val()) {
                    var form = $('#change-form-step1');
                    if (form.valid()) {
                        $(".step-more-details .step-content").addClass("hide");
                        $(".step-by-step .nested-circle ul .step01").addClass("done");
                        $(".step-by-step .nested-circle ul .step02").addClass("current");
                        $(".step-more-details .step-two-content").removeClass("hide");
                    }
                } else {
                    $("#conf-password").addClass("red-icon");
                    $("#conf-password-input").addClass("error-ver");
                    $("#conf-password-err").removeClass("hide");
                }

            }
        });

        //prev step
        $(".step-more-details .step-two-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").removeClass("done");
            $(".step-by-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-one-content").removeClass("hide");
        });

        //Step 2
        $(".step-more-details .step-two-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("validate-step2")) {
                var form = $('#change-form-step2');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        $(".step-more-details .step-content").addClass("hide");
                        $(".step-by-step .nested-circle ul .step02").addClass("done");
                        $(".step-by-step .nested-circle ul .step03").addClass("current");
                        $(".step-more-details .step-three-content").removeClass("hide");
                    });
                }
            }
        });

        //step 2 prev step
        $(".step-more-details .step-three-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").addClass("done");
            $(".step-by-step .nested-circle ul .step02").addClass("current");
            $(".step-more-details .step-three-content").addClass("hide");
            $(".step-more-details .step-two-content").removeClass("hide");
        });

        //Step 3 next
        $(".step-more-details .step-three-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-three-content")) {
                var form = $('#change-form-step3');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        var form1 = $('#change-form-step1');
                        $('input[name="AccessCode"]', form1).val(response.content.accessCode);
                        ajaxSubmit(form1, function (response) {
                            $(".step-more-details .step-content").addClass("hide");
                            $(".step-by-step .nested-circle ul .step03").addClass("done");
                            $(".step-more-details .step-four-content").removeClass("hide");
                        });
                    });
                }
            }
        });
    }

    //============== Change mobile phone Page ===============
    if ($(".change-mobile-phone").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-more-details .step-one-content")) {
                var form = $('#change-form-step1');
                if (form.valid()) {
                    $(".step-more-details .step-content").addClass("hide");
                    $(".step-by-step .nested-circle ul .step01").addClass("done");
                    $(".step-by-step .nested-circle ul .step02").addClass("current");
                    $(".step-more-details .step-two-content").removeClass("hide");
                }
            }
        });

        //prev step
        $(".step-more-details .step-two-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").removeClass("done");
            $(".step-by-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-one-content").removeClass("hide");
        });

        // Step 2 -> next
        $(".step-more-details .step-two-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("validate-step2")) {
                var form = $('#change-form-step2');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        $(".step-more-details .step-content").addClass("hide");
                        $(".step-by-step .nested-circle ul .step02").addClass("done");
                        $(".step-by-step .nested-circle ul .step03").addClass("current");
                        $(".step-more-details .step-three-content").removeClass("hide");
                    });
                }
            }
        });

        //step 2 prev step
        $(".step-more-details .step-three-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").addClass("done");
            $(".step-by-step .nested-circle ul .step02").addClass("current");
            $(".step-more-details .step-three-content").addClass("hide");
            $(".step-more-details .step-two-content").removeClass("hide");
        });

        //Step 3 -> next
        $(".step-more-details .step-three-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-three-content")) {
                var form = $('#change-form-step3');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        var form1 = $('#change-form-step1');
                        $('input[name="AccessCode"]', form1).val(response.content.accessCode);
                        ajaxSubmit(form1, function (response) {
                            $(".step-more-details .step-content").addClass("hide");
                            $(".step-by-step .nested-circle ul .step03").addClass("done");
                            $(".step-more-details .step-four-content").removeClass("hide");
                        });
                    });
                }
            }
        });
    }
    //============== Change email address Page ===============
    if ($(".change-email-address").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-more-details .box-email")) {
                var form = $('#change-form-step1');
                if (form.valid()) {
                    $(".step-more-details .step-content").addClass("hide");
                    $(".step-by-step .nested-circle ul .step01").addClass("done");
                    $(".step-by-step .nested-circle ul .step02").addClass("current");
                    $(".step-more-details .step-two-content").removeClass("hide");
                }
            }
        });

        //prev step
        $(".step-more-details .step-two-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").removeClass("done");
            $(".step-by-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-one-content").removeClass("hide");
        });

        //Step 2
        $(".step-more-details .step-two-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("validate-step2")) {
                var form = $('#change-form-step2');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        $(".step-more-details .step-content").addClass("hide");
                        $(".step-by-step .nested-circle ul .step02").addClass("done");
                        $(".step-by-step .nested-circle ul .step03").addClass("current");
                        $(".step-more-details .step-three-content").removeClass("hide");
                    });
                }
            }
        });

        //step 2 prev step
        $(".step-more-details .step-three-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").addClass("done");
            $(".step-by-step .nested-circle ul .step02").addClass("current");
            $(".step-more-details .step-three-content").addClass("hide");
            $(".step-more-details .step-two-content").removeClass("hide");
        });

        //Step 3 -> next
        $(".step-more-details .step-three-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-three-content")) {
                var form = $('#change-form-step3');
                if (form.valid()) {
                    ajaxSubmit(form, function (response) {
                        var form1 = $('#change-form-step1');
                        $('input[name="AccessCode"]', form1).val(response.content.accessCode);
                        ajaxSubmit(form1, function (response) {
                            $(".step-more-details .step-content").addClass("hide");
                            $(".step-by-step .nested-circle ul .step03").addClass("done");
                            $(".step-more-details .step-four-content").removeClass("hide");
                        });
                    });
                }
            }
        });
    }
    //============== Edit bank information Page ===============
    if ($(".edit-bank-information").length) {
        //next step
        //Step 1
        $(".step-more-details .step-one-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-more-details .step-one-content")) {
                $(".step-more-details .step-content").addClass("hide");
                $(".step-by-step .nested-circle ul .step01").addClass("done");
                $(".step-by-step .nested-circle ul .step02").addClass("current");
                $(".step-more-details .step-two-content").removeClass("hide");
            }
        });

        //prev step
        $(".step-more-details .step-two-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").removeClass("done");
            $(".step-by-step .nested-circle ul .step02").removeClass("current");
            $(".step-more-details .step-one-content").removeClass("hide");
        });

        //Step 2
        $(".step-more-details .step-two-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("validate-step2")) {
                $(".step-more-details .step-content").addClass("hide");
                $(".step-by-step .nested-circle ul .step02").addClass("done");
                $(".step-by-step .nested-circle ul .step03").addClass("current");
                $(".step-more-details .step-three-content").removeClass("hide");
            }
        });

        //step 2 prev step
        $(".step-more-details .step-three-content .bottom-button .btn-cancel").on("click", function () {
            $(".step-more-details .step-content").addClass("hide");
            $(".step-by-step .nested-circle ul .step01").addClass("done");
            $(".step-by-step .nested-circle ul .step02").addClass("current");
            $(".step-more-details .step-three-content").addClass("hide");
            $(".step-more-details .step-two-content").removeClass("hide");
        });

        //Step 2
        $(".step-more-details .step-three-content .bottom-button .btn-next").on("click", function () {
            if (!validateInput("step-three-content")) {
                $(".step-more-details .step-content").addClass("hide");
                $(".step-by-step .nested-circle ul .step03").addClass("done");
                $(".step-more-details .step-four-content").removeClass("hide");
            }
        });
    }

    //============== contact-us ===============
    if ($(".contact-page").length) { }
    // ============= Resources ===============
    if ($(".resources-page").length) {
        // click tab
        $(".simply-tab").click(function () {
            var index = $(this).index() + 1;
            $(".simply-tab").removeClass("active");
            $(this).addClass("active");
            $(".tab-content").addClass("hide");
            $(".tab-order0" + index + "-content").removeClass("hide");
            setHeightFunc();
        });

        // click list/ grid
        $(".tab-content .icon-grid").click(function () {
            $(this).addClass("hide");
            $(this).parent().find(".icon-list").removeClass("hide");
            $(this).parent().parent().parent().find(".second-content .grid-group").removeClass("hide");
            $(this).parent().parent().parent().find(".second-content .list-group").addClass("hide");
            setHeightFunc();
        });
        $(".tab-content .icon-list").click(function () {
            $(this).addClass("hide");
            $(this).parent().find(".icon-grid").removeClass("hide");
            $(this).parent().parent().parent().find(".second-content .list-group").removeClass("hide");
            $(this).parent().parent().parent().find(".second-content .grid-group").addClass("hide");
            setHeightFunc();
        });

        // click filter year
        $(".top-content .left-menu .list-year li a").click(function () {
            $(this).parent().parent().find("li").removeClass("active");
            $(this).parent().addClass("active");
        });

        // click sub filter on tab three
        $(".cover-box .new-menu .list-sub li a").click(function () {
            $(this).parent().parent().find("li").removeClass("active");
            $(this).parent().addClass("active");
        });

        $(".select-tab .click-select").click(function (event) {
            event.stopPropagation();
            $(this).parent().addClass("open-select");
        });
        $(".select-tab .list-tab li.active .list-title").click(function (event) {
            event.stopPropagation();
            $(this).parent().parent().parent().removeClass("open-select");
        })

        $(".select-tab .list-tab").click(function (event) {
            event.stopPropagation();
        })

        $(".select-tab .list-tab li .list-title").click(function (event) {
            event.stopPropagation();
            $(".tab-content").addClass("hide");
            if ($(this).text().trim() === "Retirement Basics") {
                $(".tab-order01-content").removeClass("hide");
            } else if ($(this).text().trim() === "Videos and Webinars") {
                $(".tab-order02-content").removeClass("hide");
            } else if ($(this).text().trim() === "Publications and News") {
                $(".tab-order03-content").removeClass("hide");
            }
            $(".select-tab .click-select .title-tab").text($(this).text().trim());
            $(".select-tab .list-tab li.active").before($(this).parent());
            $(".select-tab .list-tab li").removeClass("active");
            $(this).parent().addClass("active");
            $(this).parent().parent().parent().removeClass("open-select");
        });
    }
    //============== Account Summary Page ============
    if ($(".account-summary-page").length) {

        $('.btn-fund-asset').click(function () {
            $(this).addClass('active');
            $('.btn-fund-classification').removeClass('active');
            $('.fund-asset-content').removeClass('hide');
            $('.fund-classification-content').addClass('hide');
            drawPieChart();
        })
        $('.btn-fund-classification').click(function () {
            $(this).addClass('active');
            $('.btn-fund-asset').removeClass('active');
            $('.fund-classification-content').removeClass('hide');
            $('.fund-asset-content').addClass('hide');
            drawPieChart();
        });
    }
    if ($(".account-summary-page").not('.no-charts').length) {
        //Selectmenu
        $(".big-part-three .right-white-box .top-title .group-period .ddown-here .ddown-select").selectmenu({
            classes: {
                "ui-selectmenu-menu": "dropdown-account-overtime"
            }
        });
        //Pie Chart
        var dataset = [{
            name: "Dodhe And Cox Stock",
            percent: 10
        },
        {
            name: "Fidelity Contrafund",
            percent: 15
        },
        {
            name: "Fidelity Growth Company",
            percent: 30
        },
        {
            name: "Fpa capital",
            percent: 10
        },
        {
            name: "Hartford Small Company",
            percent: 20
        },
        {
            name: "Ohio Dc Large Cap Growth",
            percent: 5
        },
        {
            name: "Templeton Foreign",
            percent: 10
        }
        ];

        var w = 150,
            h = 150;

        var outerRadius = w / 2;
        var innerRadius = outerRadius - 22;

        if ($(window).width() <= 768) {
            w = 127,
                h = 127;
            outerRadius = w / 2;
            innerRadius = outerRadius - 14;
        }

        var color = d3.scaleOrdinal().range(["#df3224", "#f0ad00", "#753d94", "#3a9edc", "#42d058", "#02dbca", "#e94fd5"]);

        var textChartTop = "Fund";
        var textChartBottom = "Allocation";
        drawPieChart();

        // ====================Line Chart=======================
        var data = [{
            year: "01/01/2017",
            value: 30000
        },
        {
            year: "02/01/2017",
            value: 38000
        },
        {
            year: "03/01/2017",
            value: 36000
        },
        {
            year: "04/01/2017",
            value: 55000
        },
        {
            year: "05/01/2017",
            value: 53000
        },
        {
            year: "06/01/2017",
            value: 50000
        },
        {
            year: "07/01/2017",
            value: 75000
        },
        {
            year: "08/01/2017",
            value: 77000
        },
        {
            year: "09/01/2017",
            value: 98000
        }
        ]

        var dataSelect = [];
        function updateLineChart() {
            if ($(window).width() >= 1024) {
                dataSelect = data;
                drawLineChart();
            } else {
                for (let i = 0; i < data.length; i++) {
                    var temp = i;
                }
                for (let j = 0; j < data.length; j++) {
                    if (j >= (temp - 6)) {
                        dataSelect.push(data[j]);
                    }
                }
                drawLineChart();
            }
        }

        updateLineChart();

        $(window).resize(function () {
            dataSelect = [];
            updateLineChart();
            drawPieChart();
        })
    }
    //============== Account Manager Page ============
    if ($(".account-manager-page").length) {
        var dataset = [{
            name: "International Stocks",
            percent: 30
        },
        {
            name: "Small-Cap Stocks",
            percent: 28
        },
        {
            name: "Large-Cap Stocks",
            percent: 20
        },
        {
            name: "Asset Allocation",
            percent: 22
        },
        {
            name: "Bonds",
            percent: 10
        }
        ];

        var textChartTop = "$355K";
        var textChartBottom = "Total Balance";

        var w = 128,
            h = 128;

        if ($(window).width() <= 768) {
            w = 109,
                h = 109;
        }

        var outerRadius = w / 2;
        var innerRadius = outerRadius - 10;

        var color = d3.scaleOrdinal().range(["#df3224", "#f0ad00", "#753d94", "#3a9edc", "#42d058"]);

        drawPieChart();

        $(window).resize(function () {
            drawPieChart();
        })

        $(".big-part-two .first-group .name").on("click", function (event) {
            event.stopPropagation();
            if ($(this).parent().index() == 6) {
                return;
            }
            var rows = $(".big-part-two .second-group ul").find('li').toArray().sort(comparer($(this).parent().index()));
            this.asc = !this.asc;
            if (this.asc) {
                $(this).parent().addClass('active');
            } else {
                $(this).parent().removeClass('active');
            }
            if (!this.asc) {
                rows = rows.reverse();
            }
            $(".big-part-two .second-group ul").empty().html(rows);
        })
    }
    //============== Enrollment Page ============
    if ($(".enrollment-page").length) {
        var step = 1;
        // next step function
        $(".step-content .next-btn").click(function () {
            var dropdownSelected = true;
            $(".step-content:nth-child(" + (step + 1) + ") .ddown-select option:selected").each(function () {
                if ($(this).text() === "Select") {
                    $(this).parent().parent().css("border", "1px solid red");
                    dropdownSelected = false
                }
            });

            if (!dropdownSelected) {
                return;
            }
            // check agree terms step 7
            if (step === 7) {
                if (!$('#cxen01').is(':checked')) {
                    return;
                }
            }
            if (!validateInput("box-step .step-content:nth-child(" + (step + 1) + ")")) {
                scrollTopPage();
                resetClsStep();
                step++;
                for (let i = 1; i < step; i++) {
                    $(".box-step .nested-circle ul li:nth-child(" + i + ")").addClass("done");
                }
                $(".box-step .nested-circle ul li:nth-child(" + step + ")").addClass("current");

                $(".box-step .step-content").addClass("hide");
                $(".box-step .step-content:nth-child(" + (step + 1) + ")").removeClass("hide");
                setHeightFunc();
            }
        });

        $(".step-five-content .middle-form .form-order05 .cover-box .box-radio input").click(function () {
            if ($(this).val() !== "one") {
                $(".step-five-content .middle-form .form-order05 .cover-box .box-radio ul li .ddown-here .ui-selectmenu-button").addClass("ui-selectmenu-disabled");
                $(".step-five-content .middle-form .form-order05 .cover-box .box-radio ul li .ddown-here .ui-selectmenu-button").addClass("ui-state-disabled");
            } else {
                $(".step-five-content .middle-form .form-order05 .cover-box .box-radio ul li .ddown-here .ui-selectmenu-button").removeClass("ui-selectmenu-disabled");
                $(".step-five-content .middle-form .form-order05 .cover-box .box-radio ul li .ddown-here .ui-selectmenu-button").removeClass("ui-state-disabled");
            }
        });

        // prev step function
        $(".step-content .pre-btn").click(function () {
            scrollTopPage();
            if (step === 1) {
                $(".about-enrollment").removeClass("hide");
                $(".box-step").addClass("hide");
                setHeightFunc();
            } else {
                step--;
                for (let i = step; i >= step; i--) {
                    $(".box-step .nested-circle ul li:nth-child(" + i + ")").removeClass("done");
                }
                $(".box-step .nested-circle ul li:nth-child(" + (step + 1) + ")").removeClass("current");
                $(".box-step .nested-circle ul li:nth-child(" + step + ")").addClass("current");

                $(".box-step .step-content").addClass("hide");
                $(".box-step .step-content:nth-child(" + (step + 1) + ")").removeClass("hide");
            }
            setHeightFunc();
        });

        function resetClsStep() {
            $(".box-step .nested-circle ul li").removeClass("done");
            $(".box-step .nested-circle ul li").removeClass("current");
        }

        $(".about-enrollment .cover-about .third-about .btn-start").click(function () {
            $(".about-enrollment").addClass("hide");
            $(".box-step").removeClass("hide");
            setHeightFunc();
        })

        //Selectmenu
        $(".ddown-here .ddown-select").selectmenu({
            classes: {
                "ui-selectmenu-menu": "dropdown-enrollment"
            },
            change: function (event, ui) {
                if ($(this).find("option:selected").text() !== "Select") {
                    $(this).parent().css("border", "1px solid #aeaeae");
                }
            }
        });

        $(".step-six-content .group-table").on("selectmenuchange", ".ddown-here .ddown-select", function (event, ui) {
            if ($(this).find("option:selected").text() !== "Select") {
                $(this).parent().css("border", "1px solid #aeaeae");
            }
        });

        $(".datepicker-birth").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true
        });
        //add new item step six
        $(".table-one .top-add .click-add").click(function () {
            var index = $(".table-one .group-table .list-table").length + 1;
            var elItem = "<div class='list-table'>"
                + "<div class='second-add'>"
                + "<span class='text'>Beneficiary " + index + "</span>"
                + "<button class='icons click-remove'></button>"
                + "</div>"
                + "<div class='add-select'>"
                + "<ul class='list-add'>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>Name</span>"
                + "<div class='input-here'>"
                + "<input type='text' placeholder='Enter Name' title='save the file'>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>Relationship</span>"
                + "<div class='input-here ddown-here big-text'>"
                + "<select name='select' class='ddown-select' title='save the file'>"
                + "<option selected='selected'>Select</option>"
                + "<option>$100</option>"
                + "<option>$200</option>"
                + "<option>$300</option>"
                + "<option>$400</option>"
                + "</select>"
                + "<span class='icons-ddown'></span>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>SSN</span>"
                + "<div class='input-here'>"
                + "<input type='text' placeholder='Enter SSN' title='save the file'>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>Date of Birth</span>"
                + "<div class='input-here date-birth'>"
                + "<input class='datepicker-birth' type='text' placeholder='dd/mm/yy' title='save the file'>"
                + "<button class='icons select-calculator'></button>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "</ul>"
                + "<div class='right-add'>"
                + "<div class='second-select'>"
                + "<span class='text'>Percentage (%)</span>"
                + "<div class='input-here'>"
                + "<input type='text' title='save the file'>"
                + "</div>"
                + "</div>"
                + "<p>"
                + "<span>Note</span> : Total percentage mus be equal to 100%"
                + "</p>"
                + "</div>"
                + "</div>"
                + "</div>";
            $(".step-six-content .middle-form .form-order06 .cover-box .box-add.table-one .group-table").append(elItem);
            $(".ddown-here .ddown-select").selectmenu({
                classes: {
                    "ui-selectmenu-menu": "dropdown-enrollment"
                }
            });
            $(".datepicker-birth").datepicker({
                dateFormat: "dd/mm/yy",
                showOtherMonths: true
            });
        })

        // clear error
        $(".step-six-content .middle-form .form-order06 .cover-box .box-add.table-one .group-table").on("focus", "input", function () {
            $(this).parent().removeClass("error-ver");
        });

        //add new item step six
        $(".table-two .top-add .click-add").click(function () {
            var index = $(".table-two .group-table .list-table").length + 1;
            var elItem = "<div class='list-table'>"
                + "<div class='second-add'>"
                + "<span class='text'>Beneficiary " + index + "</span>"
                + "<button class='icons click-remove'></button>"
                + "</div>"
                + "<div class='add-select'>"
                + "<ul class='list-add'>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>Name</span>"
                + "<div class='input-here'>"
                + "<input type='text' placeholder='Enter Name' title='save the file'>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>Relationship</span>"
                + "<div class='input-here ddown-here big-text'>"
                + "<select name='select' class='ddown-select' title='save the file'>"
                + "<option selected='selected'>Select</option>"
                + "<option>$100</option>"
                + "<option>$200</option>"
                + "<option>$300</option>"
                + "<option>$400</option>"
                + "</select>"
                + "<span class='icons-ddown'></span>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>SSN</span>"
                + "<div class='input-here'>"
                + "<input type='text' placeholder='Enter SSN' title='save the file'>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "<li>"
                + "<div class='first-select'>"
                + "<span class='text'>Date of Birth</span>"
                + "<div class='input-here date-birth'>"
                + "<input class='datepicker-birth' type='text' placeholder='dd/mm/yy' title='save the file'>"
                + "<button class='icons select-calculator'></button>"
                + "</div>"
                + "</div>"
                + "</li>"
                + "</ul>"
                + "<div class='right-add'>"
                + "<div class='second-select'>"
                + "<span class='text'>Percentage (%)</span>"
                + "<div class='input-here'>"
                + "<input type='text' title='save the file'>"
                + "</div>"
                + "</div>"
                + "<p>"
                + "<span>Note</span> : Total percentage mus be equal to 100%"
                + "</p>"
                + "</div>"
                + "</div>"
                + "</div>";
            $(".step-six-content .middle-form .form-order06 .cover-box .box-add.table-two .group-table").append(elItem);
            $(".ddown-here .ddown-select").selectmenu({
                classes: {
                    "ui-selectmenu-menu": "dropdown-enrollment"
                }
            });
            $(".datepicker-birth").datepicker({
                dateFormat: "dd/mm/yy",
                showOtherMonths: true
            });
        });
        $(".step-six-content .middle-form .form-order06 .cover-box .box-add.table-two .group-table").on("focus", "input", function () {
            $(this).parent().removeClass("error-ver");
        });

        $(".box-add .group-table").on("click", ".list-table .second-add .click-remove", function () {
            $(this).parent().parent().remove();
        });

        $('.fund-stock-value,input[name="AllocationOption"]').change(function () {
            var sum = 0;
            $('.fund-stock-value').each(function (ind, el) {
                var val = parseFloat($(el).val());
                if (val) {
                    sum += val;
                }
            });
            var isDollar = $('input[name="AllocationOption"]:checked').val() === 'Dollar';
            var total = sum;
            if (isDollar) {
                total = '$' + total;
            }
            else {
                total = total + '%';
            }
            $('.total-allocation-amount').text(total);
        });
    }
    //============== Investments Page ===========
    if ($(".investments-page").length) {
        $(".primary-content .select-tab .simply-tab").on("click", function (event) {
            if ($(event.currentTarget).text().trim() !== "Understanding Investments") {
                $(".primary-content .select-tab .simply-tab").removeClass("active");
                $(".primary-content .tab-content-group").addClass("hide");
                if ($(event.currentTarget).text().trim() === "Fund profile & prospectus") {
                    $(".primary-content .select-tab .simply-tab.order01").addClass("active");
                    $(".primary-content .tab-content-group.tab-order01-content").removeClass("hide");
                } else if ($(event.currentTarget).text().trim() === "Fund performance") {
                    $(".primary-content .select-tab .simply-tab.order02").addClass("active");
                    $(".primary-content .tab-content-group.tab-order02-content").removeClass("hide");
                } else if ($(event.currentTarget).text().trim() === "Understanding Investments") {
                    $(".primary-content .select-tab .simply-tab.order03").addClass("active");
                    $(".primary-content .tab-content-group.tab-order03-content").removeClass("hide");
                }
                setHeightFunc();
            }
        });

        $(".tab-order01-content .first-group .name").on("click", function (event) {
            event.stopPropagation();
            var rows = $(".tab-order01-content .second-group ul").find('li').toArray().sort(comparer($(this).parent().index()));
            this.asc = !this.asc;
            if (this.asc) {
                $(this).parent().addClass('active');
            } else {
                $(this).parent().removeClass('active');
            }
            if (!this.asc) {
                rows = rows.reverse();
            }
            $(".tab-order01-content .second-group ul").empty().html(rows);
        })

        $(".tab-order02-content .first-group .name").on("click", function (event) {
            event.stopPropagation();
            var outerContainers = $(".complex-table .second-group .lineage01").find('.gene01').toArray();
            this.asc = !this.asc;
            for (let index = 0; index < outerContainers.length; index++) {
                var rows = $(outerContainers[index]).find('li.gene02').toArray().sort(comparer($(this).parent().index()));
                if (this.asc) {
                    $(this).parent().addClass('active');
                } else {
                    $(this).parent().removeClass('active');
                }
                if (!this.asc) {
                    rows = rows.reverse();
                }
                $(outerContainers[index]).find("ul.lineage02").empty().html(rows);
            }
        })

        // Mobile
        // part one
        $(".select-tab .click-select").click(function (event) {
            event.stopPropagation();
            $(this).parent().addClass("open-select");
        });
        $(".select-tab .list-tab li.active .list-title").click(function (event) {
            event.stopPropagation();
            $(this).parent().parent().parent().removeClass("open-select");
        })

        $(".select-tab .list-tab").click(function (event) {
            event.stopPropagation();
        })

        $(".select-tab .list-tab li .list-title").click(function (event) {
            event.stopPropagation();
            if ($(this).text().trim() !== 'Understanding Investments') {
                selectTitleTab($(this).text().trim());
                $(".select-tab .click-select .title-tab").text($(this).text().trim());
                $(".select-tab .list-tab li.active").before($(this).parent());
                $(".select-tab .list-tab li").removeClass("active");
                $(this).parent().addClass("active");
                $(this).parent().parent().parent().removeClass("open-select");
            }
        });

        function selectTitleTab(text) {
            if (text.trim() !== "Understanding Investments") {
                $(".tab-content-group").addClass("hide");
                if (text.trim() === "Fund profile & prospectus") {
                    $(".tab-order01-content").removeClass("hide");
                } else if (text.trim() === "Fund performance") {
                    $(".tab-order02-content").removeClass("hide");
                } else if (text.trim() === "Understanding Investments") {
                    $(".tab-order03-content").removeClass("hide");
                }
            }
        }

        $(".big-part-three .group-descriptions .demo-value .click-me").click(function () {
            $(".big-part-three .group-descriptions .demo-value").removeClass("show-me");
            $(this).parent().addClass("show-me");
        })

        // click show dropdown list
        $(".blue-box .click-select").click(function (event) {
            event.stopPropagation();
            $(this).parent().addClass("open-select");
        });
        $(".blue-box .list-tab li.active .list-title").click(function (event) {
            event.stopPropagation();
            $(this).parent().parent().parent().removeClass("open-select");
        })

        $(".blue-box .list-tab").click(function (event) {
            event.stopPropagation();
        })
    }
    //============= Smart Plan Page ==================
    if ($(".smart-plan-page").length) {
        //click btn enrollment 
        $(".content-plan .box-content .btn-enrol").click(function () {
            $(".content-plan").addClass("hide");
            $(".content-plan.content-step02").removeClass("hide");
            setHeightFunc();
            scrollTopPage();
        })

        //click btn review change / cancel change
        $(".content-plan .box-content .btn-change").click(function () {
            $(".content-plan").addClass("hide");
            if ($(this).text().trim() === "Continue & Review changes") {
                $(".content-plan.content-step03").removeClass("hide");
            } else if ($(this).text().trim() === "Cancel changes") {
                $(".content-plan.content-step01").removeClass("hide");
            } else if ($(this).text().trim() === "make changes") {
                $(".content-plan.content-step06").removeClass("hide");
            }
            setHeightFunc();
            scrollTopPage();
        })
        // click button on update smart plan
        $(".content-plan .box-content .btn-button").click(function () {
            if ($(this).text().trim() === "save") {
                $(".content-plan").addClass("hide");
                $(".content-plan.content-step04").removeClass("hide");
            } else if ($(this).text().trim() === "edit") {
                $(".content-plan").addClass("hide");
                $(".content-plan.content-step05").removeClass("hide");
            } else if ($(this).text().trim() === "cancel") {
                $(".content-plan").addClass("hide");
                $(".content-plan.content-step02").removeClass("hide");
            } else if ($(this).text().trim() === "Continue & Review changes") {
                $(".content-plan").addClass("hide");
                $(".content-plan.content-step03").removeClass("hide");
            }
            setHeightFunc();
            scrollTopPage();
        })
        //Selectmenu
        $(".content-plan .ddown-here .ddown-select").selectmenu({
            classes: {
                "ui-selectmenu-menu": "dropdown-smart"
            }
        });
    }

    //========= beneficiaries ============
    if ($(".beneficiaries-page").length) {
        function setHeigthGroup() {
            $(".box-right").css("height", "auto");
            $(".box-left").css("height", "auto");
            if ($(window).width() > 1024) {
                var heigthLeft = $(".box-left").height();
                var heigthRight = $(".box-right").height();
                if (heigthLeft > heigthRight) {
                    $(".box-right").height(heigthLeft);
                } else {
                    $(".box-left").height(heigthRight);
                }
            }
        }
        setHeigthGroup();
        $(window).resize(function () {
            setHeigthGroup();
        });
    }

    // ========= beneficiaries-copy-account-page =============
    if ($(".beneficiaries-copy-account-page").length) {
        function setHeigthGroup() {
            var heigthLeft = $(".box-left").height();
            var heigthRight = $(".box-right").height();
            if ($(window).width() >= 1024) {
                if (heigthLeft > heigthRight) {
                    $(".box-right").height(heigthLeft);
                } else {
                    $(".box-left").height(heigthRight);
                }
            } else {
                $(".box-right").height("auto");
            }
        }

        setHeigthGroup();

        setTimeout(function () {
            $(window).resize(function () {
                setHeigthGroup();
            })
        }, 150)
    }

    // ========== statements ==============
    if ($(".statements-page").length) {
        // click filter year
        $(".state-year .list-state-year li .year").click(function () {
            $(".state-year .list-state-year li").removeClass("active");
            $(this).parent().addClass("active");
        });
    }
    // ============ account summary edit ===========
    if ($(".account-edit").length) {
        // review 
        $(".btn-continue").click(function () {
            $(".second-content").removeClass("error");
            $(".input-here").removeClass("show-percent");
            var total = 0;
            $(".box-content .number-only").each(function () {
                if ($(this).val() !== "") {
                    total += parseInt($(this).val());
                    $(this).parent().addClass("show-percent");
                }
            });
            $(".box-total .percent .value").text(total + "%");
            if (total > 100) {
                $(".second-content").addClass("error");
            }
            if (!validateInput("cover-content.edit-ver .box-content .input-here") && total <= 100) {
                $(".cover-content").addClass("hide");
                $(".cover-content.review-ver").removeClass("hide");
                scrollTopPage();
            }
        });
        // back to edit
        $(".btn-edit-me").click(function () {
            $(".cover-content").addClass("hide");
            $(".cover-content.edit-ver").removeClass("hide");
        });
        // success
        $(".review-ver .btn-save-me").click(function () {
            var form = $('#edit-summary-form');
            if (form.valid()) {
                ajaxSubmit(form, function () {
                    $(".cover-content").addClass("hide");
                    $(".cover-content.compelete").removeClass("hide");
                    scrollTopPage();
                });
            }
        });

        // total
        $(".box-content .number-only").keyup(function () {
            $(".second-content").removeClass("error");
            $(".input-here").removeClass("show-percent");
            var total = 0;
            $(".box-content .number-only").each(function () {
                if ($(this).val() !== "") {
                    total += parseInt($(this).val());
                    $(this).parent().addClass("show-percent");
                }
            });
            $(".box-total .percent .value").text(total + "%");
            if (total > 100) {
                $(".second-content").addClass("error");
            }
        });
    }

    // ========== account summary disable ========
    if ($(".account-disable").length) {
        $(".btn-ok").click(function () {
            $(".account-disable").removeClass("success-ver");
        });
    }

    // ========== asset allocation tool =========
    if ($(".asset-tool").length) {
        var step = 1;
        // next step function
        $(".btn-next-step").click(function () {
            if (!validateInput("step-more-details .step-content:nth-child(" + step + ")")) {
                if (step === 3) {
                    var form = $(this).closest('form');
                    ajaxSubmit(form, function (response) {
                        // set results
                        var data = response.content;
                        var ul = $('.portfolio-models');
                        ul.empty();
                        for (var index in data.PortfolioModels) {
                            var model = data.PortfolioModels[index];
                            ul.append('<li><ul class="list-row">'
                                + '<li><span class="title">' + model.FundName + '</span></li>'
                                + '<li><span class="percent">' + model.Conservative + '%</span></li>'
                                + '<li><span class="percent">' + model.ModeratelyConservative + '%</span></li>'
                                + '<li><span class="percent">' + model.Moderate + '%</span></li>'
                                + '<li><span class="percent">' + model.ModeratelyAggressive + '%</span></li>'
                                + '</ul></li>');
                        }

                        var selectedUl = $('.portfolio-selected-model');
                        selectedUl.empty();
                        selectedUl.append('<li><span class="name">Aggressive</span></li>');
                        for (var index in data.PortfolioModels) {
                            var model = data.PortfolioModels[index];
                            selectedUl.append('<li><span class="percent">' + model.Aggressive + '%</span></li>');
                        }

                        // display Funds
                        var fundList = $('.fund-list');
                        fundList.empty();
                        for (var index in data.Funds) {
                            var fund = data.Funds[index];
                            fundList.append(
                                '<div class="box-a-detail cen-z">'
                                + '<div class="left-content">'
                                + '<span class="title-box">' + fund.FundName + '<span class="icons arrow-icon"></span></span>'
                                + '<span class="num-percent">' + fund.Value + '%</span>'
                                + '</div>'
                                + '<div class="right-content">'
                                + '<ul class="list-box">'
                                + '</ul>'
                                + '</div>'
                                + '</div>');

                            // append items
                            var itemList = $('.list-box', fundList.children().last());
                            for (var childIndex in fund.Items) {
                                var child = fund.Items[childIndex];
                                itemList.append('<li><span class="text">' + child + '</span></li>');
                            }
                        }

                        nextStep();
                    });
                }
                else {
                    nextStep();
                }
            }
        });

        // previous step function
        $(".btn-previous-step").click(function () {
            scrollTopPage();
            resetClsStep();
            step--;
            for (let i = 1; i < step; i++) {
                $(".step-by-step .nested-circle ul li:nth-child(" + i + ")").addClass("done");
            }
            $(".step-by-step .nested-circle ul li:nth-child(" + step + ")").addClass("current");

            $(".step-more-details .step-content").addClass("hide");
            $(".step-more-details .step-content:nth-child(" + step + ")").removeClass("hide");
            if (step === 3) {
                drawBarChart();
            }
        });

        function nextStep() {
            scrollTopPage();
            resetClsStep();
            step++;
            for (let i = 1; i < step; i++) {
                $(".step-by-step .nested-circle ul li:nth-child(" + i + ")").addClass("done");
            }
            $(".step-by-step .nested-circle ul li:nth-child(" + step + ")").addClass("current");

            $(".step-more-details .step-content").addClass("hide");
            $(".step-more-details .step-content:nth-child(" + step + ")").removeClass("hide");
            if (step === 3) {
                drawBarChart();
            }
        };

        function resetClsStep() {
            $(".step-by-step .nested-circle ul li").removeClass("done");
            $(".step-by-step .nested-circle ul li").removeClass("current");
            $(".step-by-step-mobi .nested-circle ul li").removeClass("done");
            $(".step-by-step-mobi .nested-circle ul li").removeClass("current");
        }

        function drawBarChart() {
            var data = [{
                name: "Porfolio A",
                upValue: 115000,
                downValue: 80000
            },
            {
                name: "Porfolio B",
                upValue: 125000,
                downValue: 85000
            },
            {
                name: "Porfolio C",
                upValue: 140000,
                downValue: 90000
            },
            {
                name: "Porfolio D",
                upValue: 150000,
                downValue: 95000
            }
            ];

            var formatNumber = d3.format(",d");

            data.forEach(function (d) {
                d.downValue = -(d.downValue);
            });

            var series = d3.stack()
                .keys(["upValue", "downValue"])
                .offset(d3.stackOffsetDiverging)
                (data);

            var svg, width, height, margin;
            $(".bar-chart svg").remove();
            svg = d3.select(".bar-chart").append("svg").attr("width", "100%").attr("height", "100%");
            width = $(".bar-chart").width();
            height = $(".bar-chart").height() - 50;
            if ($(window).width() >= 1024) {
                margin = {
                    top: 30,
                    right: 10,
                    bottom: 40,
                    left: 60
                }
            } else if ($(window).width() <= 320) {
                margin = {
                    top: 20,
                    right: 10,
                    bottom: 20,
                    left: 40
                }
            } else {
                margin = {
                    top: 20,
                    right: 10,
                    bottom: 20,
                    left: 60
                };
            }
            var x = d3.scaleBand()
                .domain(data.map(function (d) {
                    return d.name;
                }))
                .range([margin.left, width - margin.right])
                .paddingOuter(0.2)
                .paddingInner(0.5);
            var y = d3.scaleLinear()
                .domain([d3.min(series, stackMin), d3.max(series, stackMax)])
                .rangeRound([height - margin.bottom, margin.top]);
            var z = d3.scaleOrdinal().range(["#3c9edb", "#da291c"]);
            svg.append("g")
                .attr("class", "group-rect")
                .selectAll("g")
                .data(series)
                .enter().append("g")
                .attr("fill", function (d) {
                    return z(d.key);
                })
                .selectAll("rect")
                .data(function (d) {
                    return d;
                })
                .enter().append("rect")
                .attr("width", x.bandwidth)
                .attr("x", function (d) {
                    return x(d.data.name);
                })
                .attr("y", function (d) {
                    return y(d[1]);
                })
                .attr("height", function (d) {
                    return y(d[0]) - y(d[1]);
                });

            svg.append("g")
                .attr("class", "text-number")
                .append("text")
                .attr("x", function () {
                    if ($(window).width() <= 375) {
                        return 0;
                    } else {
                        return 5;
                    }
                })
                .attr("y", function () {
                    if ($(window).width() >= 1024) {
                        return 90;
                    } else if ($(window).width() <= 375) {
                        return 55;
                    } else {
                        return 70;
                    }
                })
                .attr("fill", "#282828")
                .attr("font-family", "Gotham")
                .attr("font-size", function () {
                    if ($(window).width() >= 1024) {
                        return "13px";
                    } else {
                        return "9px";
                    }
                })
                .text("$100,000")

            svg.append("g")
                .selectAll("g")
                .data(series[0])
                .enter().append("text")
                .attr("text-anchor", "middle")
                .attr("fill", "#282828")
                .attr("font-size", function () {
                    if ($(window).width() >= 1024) {
                        return "12px";
                    } else {
                        return "8px";
                    }
                })
                .attr("font-family", "Gotham")
                .attr("x", function (d) {
                    if ($(window).width() >= 1024) {
                        return x(d.data.name) + 20;
                    } else if ($(window).width() <= 320) {
                        return x(d.data.name) + 14;
                    } else {
                        return x(d.data.name) + 16;
                    }
                })
                .attr("y", function (d) {
                    return y(d[1]) - 5;
                })
                .text(function (d) {
                    return "$" + formatNumber(d[1]);
                })

            svg.append("g")
                .selectAll("g")
                .data(series[1])
                .enter().append("text")
                .attr("text-anchor", "middle")
                .attr("fill", "#282828")
                .attr("font-size", function () {
                    if ($(window).width() >= 1024) {
                        return "12px";
                    } else {
                        return "8px";
                    }
                })
                .attr("font-family", "Gotham")
                .attr("x", function (d) {
                    if ($(window).width() >= 1024) {
                        return x(d.data.name) + 20;
                    } else if ($(window).width() <= 320) {
                        return x(d.data.name) + 14;
                    } else {
                        return x(d.data.name) + 16;
                    }
                })
                .attr("y", function (d) {
                    return y(d[0]) + 19;
                })
                .text(function (d) {
                    if (d[0] < 0) {
                        return "$" + formatNumber(-d[0]);
                    }
                    return "$" + formatNumber(d[0]);
                })

            svg.append("g")
                .attr("transform", "translate(0," + y(0) + ")")
                .call(customXAxis);

            function stackMin(serie) {
                return d3.min(serie, function (d) {
                    return d[0];
                });
            }

            function stackMax(serie) {
                return d3.max(serie, function (d) {
                    return d[1];
                });
            }

            function customXAxis(gTemp) {
                gTemp.call(d3.axisBottom(x).tickSizeOuter(0).tickSizeInner(0));
                gTemp.selectAll(".tick").remove();
                gTemp.selectAll("path").attr("stroke", "#d6d6d6");
            }
        }

        $(window).resize(function () {
            if ($(".asset-tool").length) {
                drawBarChart();
            }
        });
    }

    //=============== Upload File Page ============================
    if ($(".upload-file-page").length) {
        var ul = $(".content-progress ul");
        $('#fileupload').fileupload({
            dropZone: $('#drop-area'),
            singleFileUploads: true,
            add: function (e, data) {
                var valInput;
                if ($(".txt-filename").val() === "") {
                    valInput = data.files[0].name;
                } else {
                    valInput = $(".txt-filename").val() + ", " + data.files[0].name;
                }
                $(".txt-filename").val(valInput);
                var tpl = $("<li class='item-upload'>"
                    + "<div class='txt-title'>"
                    + "<span class='text-title'>" + data.files[0].name + "</span>"
                    + "<span class='percent'>45%</span>"
                    + "<a href='javascript:;' class='click-delete'>"
                    + "<span class='icons delete-icon'></span>"
                    + "</a>"
                    + "<div class='clear'></div>"
                    + "</div>"
                    + "<p class='progress-bar'>"
                    + "<span class='show-progress'></span>"
                    + "</p>"
                    + "<p class='txt-desc'>Uploading...(<span class='total-progress'>0.00</span> of <span> " + formatFileSize(data.files[0].size) + "</span>)</p>"
                    + "</li>");
                // Add the HTML to the UL element
                data.context = tpl.appendTo(ul);
                tpl.find('.click-delete').click(function () {
                    tpl.fadeOut(function () {
                        tpl.remove();
                        $(".txt-filename").val("");
                        var txtFilesName;
                        $(".item-upload").each(function () {
                            txtFilesName = $(this).find(".text-title").text();
                        });
                        $(".txt-filename").val(txtFilesName);
                    });
                });

                // Initialize the knob plugin
                tpl.find('input').knob();
                // Automatically upload the file once it is added to the queue
                var jqXHR = data.submit();
            },
            progress: function (e, data) {
                // Calculate the completion percentage of the upload
                var progress = parseInt(data.loaded / data.total * 100, 10);
                // Update the hidden input field and trigger a change
                // so that the jQuery knob plugin knows to update the dial
                data.context.find('.show-progress').css("width", progress + "%");
                data.context.find('.percent').text(progress + "%");
                data.context.find('.total-progress').text(formatFileSize(data.loaded));
                if (progress === 100) {
                    data.context.find('.txt-desc').empty();
                    data.context.find('.txt-desc').append("<span class='total-progress'>" + formatFileSize(data.files[0].size) + "</span> of <span> " + formatFileSize(data.files[0].size) + "</span>");
                    data.context.addClass("succes-upload");
                }
            },
            done: function (e, data) {
                // set file id, so that it can be used when submitting all data
                var fileId = data.result[0];
                data.context.attr('file-id', fileId);
            },
            fail: function (e, data) {
                data.context.addClass('error');
            }
        });
        // Prevent the default action when a file is dropped on the window
        $(document).on('drop dragover', function (e) {
            e.preventDefault();
        });
        // Helper function that formats the file sizes
        function formatFileSize(bytes) {
            if (typeof bytes !== 'number') {
                return '';
            }
            if (bytes >= 1000000000) {
                return (bytes / 1000000000).toFixed(2) + ' GB';
            }
            if (bytes >= 1000000) {
                return (bytes / 1000000).toFixed(2) + ' MB';
            }
            return (bytes / 1000).toFixed(2) + ' KB';
        }
        // click browser
        $(".btn-browser").click(function () {
            $(this).parent().find('input').click();
        });

        // click upload
        if ($(window).width() >= 1024) {
            $(".upload-box .btn-upload").click(function () {
                var form = $('#file-form');
                ajaxSubmit(form, function (response) {
                    $(".group-content").addClass("hide");
                    $(".succeed-box").removeClass("hide");
                });
            })
        } else {
            $(".upload-box .btn-upload").click(function () {
                var form = $('#file-form');
                ajaxSubmit(form, function (response) {
                    $(".group-content").addClass("hide");
                    $(".succeed-box").removeClass("hide");
                    $(".bold-title").addClass("hide");
                    $(".bold-title-completed").removeClass("hide");
                });
            })
        }
    }


    //=============== File Manager Page =======================
    if ($(".file-manager-page").length) {
        //click remove item
        $(".group-list .list-colum li .list-row .click-delete").click(function () {
            $(this).parent().parent().parent().parent().find(".delete-file").removeClass("hide");
        })

        $(".group-list .list-colum li .delete-file .box-select .btn-yes").click(function () {
            var theThis = $(this);
            var fileId = theThis.closest('li').data('fileid');
            $.ajax({
                url: '/Account/DeleteFile?fileId=' + fileId,
                type: 'POST',
                success: function (result) {
                    theThis.parent().parent().parent().remove();
                }
            });

        })

        $(".group-list .list-colum li .delete-file .box-select .btn-no").click(function () {
            $(this).parent().parent().addClass("hide");
        })
    }

    //=============== Beneficiaries Copy Accoun Page ===============
    if ($(".beneficiaries-copy-account-page").length) {
        //checked all
        $(".table-box table thead tr th.column01 #cxen00").click(function () {
            $(".table-box table tbody tr td.column01 input:checkbox").not(this).prop("checked", this.checked);
        });

        $('.btn-copy-beneficiaries').click(function () {
            var ids = [];
            $('.select-accout:checked').each(function (ind, el) {
                ids.push($(el).data('number'));
            });
            var data = { accountNumbers: ids };
            $.ajax({
                url: '/Account/CopyBeneficiaries',
                type: 'POST',
                data: data,
                success: function (result) {
                    window.location = "/Account/Beneficiaries";
                }
            });
        });
    }

    //=============== Add Benificiary Page ===============
    if ($(".add-benificiary-page").length) {//add new
        $(".box-add .top-add .click-add").click(function () {
            var index = $(".box-add .group-table .list-table").length + 1;
            var elItem = "<div class='list-table'>" +
                "<div class='second-add'>" +
                "<span class='text'>Beneficiary " + index + "</span>" +
                "<button class='icons click-remove'></button>" +
                "</div>" +
                "<div class='item-table'>" +
                "<div class='add-select'>" +
                "<ul class='list-add'>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Name</span>" +
                "<div class='input-here'>" +
                "<input type='text' placeholder='Enter Name' title='save the file'>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Relationship</span>" +
                "<div class='input-here ddown-here big-text'>" +
                "<select name='select' class='ddown-select' title='save the file'>" +
                "<option selected='selected'>Select</option>" +
                "<option>Spouse</option>" +
                "<option>Father</option>" +
                "<option>Brother</option>" +
                "<option>Nephew</option>" +
                "<option>Child</option>" +
                "</select>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select text-ssn'>" +
                "<span class='text'>SSN</span>" +
                "<div class='input-here'>" +
                "<input type='text' placeholder='Enter SSN' title='save the file'>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Date of Birth</span>" +
                "<div class='input-here date-birth'>" +
                "<input class='datepicker-birth' type='text' placeholder='dd/mm/yy' title='save the file'>" +
                "<button class='icons select-calculator'></button>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "</ul>" +
                "</div>" +
                "<div class='group-select-right'>" +
                "<div class='number-percent ver-y'>" +
                "<span class='text'>Percentage (%)</span>" +
                "<div class='input-here'>" +
                "<input type='text' title='save the file'>" +
                "</div>" +
                "<div class='clear'></div>" +
                "</div>" +
                "<div class='note-text'>" +
                "<p><span>Note</span> : Total percentage mus be equal to 100% copy</p>" +
                "</div>" +
                "</div>" +
                "<div class='clear'></div>" +
                "</div>" +
                "</div>";
            $(".box-add .group-table").append(elItem);
            $(".ddown-select").selectmenu();
            $(".datepicker-birth").datepicker({
                dateFormat: "mm/dd/yy",
                showOtherMonths: true
            });
        })

        $(".box-add .group-table").on("selectmenuchange", ".ddown-select", function (event, ui) {
            if ($(this).find("option:selected").text() !== "Select") {
                $(this).parent().css("border", "1px solid #aeaeae");
            }
        });
        //remove item
        $(".box-add .group-table").on("click", ".list-table .second-add .click-remove", function () {
            $(this).parent().parent().remove();
        })
        // click add 
        $(".btn-add").click(function () {
            var dropdownSelected = true;
            $(".box-add .group-table .ddown-select option:selected").each(function () {
                if ($(this).text() === "Select") {
                    $(this).parent().parent().css("border", "1px solid red");
                    dropdownSelected = false
                }
            });
            if (!validateInput("box-add .group-table .list-table .input-here") && dropdownSelected) {
                var form = $(this).closest('form');
                form.submit();
            }
        })

        // clear error
        $(".box-add .group-table").on("focus", ".input-here input", function () {
            $(this).parent().removeClass("error-ver")
        });
    }

    //=============== Modify Beneficiaries Page ===============
    if ($(".modify-beneficiaries-page").length) {
        //add new
        $(".box-add.primary-beneficiary .top-add .click-add").click(function () {
            var index = $(".box-add.primary-beneficiary .group-table .list-table").length + 1;
            var elItem = "<div class='list-table'>" +
                "<div class='second-add'>" +
                "<span class='text'>Beneficiary " + index + "</span>" +
                "<button class='icons click-remove'></button>" +
                "</div>" +
                "<div class='item-table'>" +
                "<div class='add-select'>" +
                "<ul class='list-add'>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Name</span>" +
                "<div class='input-here'>" +
                "<input type='text' placeholder='Enter Name' title='save the file'>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Relationship</span>" +
                "<div class='input-here ddown-here big-text'>" +
                "<select name='select' class='ddown-select' title='save the file'>" +
                "<option selected='selected'>Select</option>" +
                "<option>Spouse</option>" +
                "<option>Father</option>" +
                "<option>Brother</option>" +
                "<option>Nephew</option>" +
                "<option>Child</option>" +
                "</select>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select text-ssn'>" +
                "<span class='text'>SSN</span>" +
                "<div class='input-here'>" +
                "<input type='text' placeholder='Enter SSN' title='save the file'>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Date of Birth</span>" +
                "<div class='input-here date-birth'>" +
                "<input class='datepicker-birth' type='text' placeholder='dd/mm/yy' title='save the file'>" +
                "<button class='icons select-calculator'></button>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "</ul>" +
                "</div>" +
                "<div class='group-select-right'>" +
                "<div class='number-percent ver-y'>" +
                "<span class='text'>Percentage (%)</span>" +
                "<div class='input-here'>" +
                "<input type='text' title='save the file'>" +
                "</div>" +
                "<div class='clear'></div>" +
                "</div>" +
                "<div class='note-text'>" +
                "<p><span>Note</span> : Total percentage mus be equal to 100% copy</p>" +
                "</div>" +
                "</div>" +
                "<div class='clear'></div>" +
                "</div>" +
                "</div>";
            $(".box-add.primary-beneficiary .group-table").append(elItem);
            $(".ddown-select").selectmenu();
            $(".datepicker-birth").datepicker({
                dateFormat: "mm/dd/yy",
                showOtherMonths: true
            });
        })
        //remove item
        $(".box-add.primary-beneficiary .group-table").on("click", ".list-table .second-add .click-remove", function () {
            $(this).parent().parent().remove();
        })

        $(".box-add.contingent-beneficiaries .top-add .click-add").click(function () {
            var index = $(".box-add.contingent-beneficiaries .group-table .list-table").length + 1;
            var elItem = "<div class='list-table'>" +
                "<div class='second-add'>" +
                "<span class='text'>Beneficiary " + index + "</span>" +
                "<button class='icons click-remove'></button>" +
                "</div>" +
                "<div class='item-table'>" +
                "<div class='add-select'>" +
                "<ul class='list-add'>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Name</span>" +
                "<div class='input-here'>" +
                "<input type='text' placeholder='Enter Name' title='save the file'>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Relationship</span>" +
                "<div class='input-here ddown-here big-text'>" +
                "<select name='select' class='ddown-select' title='save the file'>" +
                "<option selected='selected'>Select</option>" +
                "<option>Spouse</option>" +
                "<option>Father</option>" +
                "<option>Brother</option>" +
                "<option>Nephew</option>" +
                "<option>Child</option>" +
                "</select>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select text-ssn'>" +
                "<span class='text'>SSN</span>" +
                "<div class='input-here'>" +
                "<input type='text' placeholder='Enter SSN' title='save the file'>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "<li>" +
                "<div class='first-select'>" +
                "<span class='text'>Date of Birth</span>" +
                "<div class='input-here date-birth'>" +
                "<input class='datepicker-birth' type='text' placeholder='dd/mm/yy' title='save the file'>" +
                "<button class='icons select-calculator'></button>" +
                "</div>" +
                "</div>" +
                "</li>" +
                "</ul>" +
                "</div>" +
                "<div class='group-select-right'>" +
                "<div class='number-percent ver-y'>" +
                "<span class='text'>Percentage (%)</span>" +
                "<div class='input-here'>" +
                "<input type='text' title='save the file'>" +
                "</div>" +
                "<div class='clear'></div>" +
                "</div>" +
                "<div class='note-text'>" +
                "<p><span>Note</span> : Total percentage mus be equal to 100% copy</p>" +
                "</div>" +
                "</div>" +
                "<div class='clear'></div>" +
                "</div>" +
                "</div>";
            $(".box-add.contingent-beneficiaries .group-table").append(elItem);
            $(".ddown-select").selectmenu();
            $(".datepicker-birth").datepicker({
                dateFormat: "dd/mm/yy",
                showOtherMonths: true
            });
        })
        //remove item
        $(".box-add.contingent-beneficiaries .group-table").on("click", ".list-table .second-add .click-remove", function () {
            $(this).parent().parent().remove();
        })
    }

    //=============== Account Fund Exchange Page ===============
    if ($(".account-fund-exchange").length) {
        //Pie Chart
        var modelInput = $('#end-result-exchange-model');
        var model = modelInput.length ? JSON.parse(modelInput.val()) : {};
        var dataset = [{
            name: "Templeton Foreign",
            percent: model.TempletonForeign
        },
        {
            name: "Ohio DC Small Cap Growth",
            percent: model.OhioDCSmallCapGrowth 
        },
        {
            name: "Vanguard Capital Opportunity",
            percent: model.VanguardCapitalOpportunity
        },
        {
            name: "Dodge & Cox Stocks",
            percent: model.DodgeAndCoxStocks
        },
        {
            name: "Fidelity Contrafund",
            percent: model.FidelityContrafund
        },
        {
            name: "Fidelity Growth Company",
            percent: model.FidelityGrowthCompany
        },
        {
            name: "Ohio DC Large Cap Growth",
            percent: model.OhioDCLargeCapGrowth
        },
        {
            name: "Lifpath 2020",
            percent: model.Lifepath2020
        },
        {
            name: "Ohio DC Intermediate Bond",
            percent: model.OhioDCIntermediateBond
        },
        {
            name: "Vanguard Total Bond Market Index",
            percent: model.VanguardTotalBondMarketIndex
        }
        ];
        var datasetDynamic = [{
            name: "Templeton Foreign",
            percent: 0
        },
        {
            name: "Ohio DC Small Cap Growth",
            percent: 0
        },
        {
            name: "Vanguard Capital Opportunity",
            percent: 0
        },
        {
            name: "Dodge & Cox Stocks",
            percent: 0
        },
        {
            name: "Fidelity Contrafund",
            percent: 0
        },
        {
            name: "Fidelity Growth Company",
            percent: 0
        },
        {
            name: "Ohio DC Large Cap Growth",
            percent: 0
        },
        {
            name: "Lifpath 2020",
            percent: 0
        },
        {
            name: "Ohio DC Intermediate Bond",
            percent: 0
        },
        {
            name: "Vanguard Total Bond Market Index",
            percent: 0
        }
        ];

        var w = 140,
            h = 140;

        var outerRadius = w / 2;
        var innerRadius = outerRadius - 22;

        if ($(window).width() <= 768) {
            w = 108,
                h = 108;
            outerRadius = w / 2;
            innerRadius = outerRadius - 14;
        }

        var color = d3.scaleOrdinal().range(["#df3224", "#f0ad00", "#753d94", "#3a9edc", "#42d058", "#02dbca", "#e94fd5"]);

        var textChartTop = "";
        var textChartBottom = "";
        drawPieChart();
        drawPieChartDynamic();

        // type in input box to change pie chart
        $(".desired-allocation input").keyup(function () {
            var index = $(this).parents(".desired-allocation").find("input").index($(this));
            if ($(this).val() === '') {
                datasetDynamic[index].percent = 0;
            }
            else if (isPositiveNum($(this).val())) {
                datasetDynamic[index].percent = parseInt($(this).val());
            }
            else {
                return;
            }

            var pass = false;
            datasetDynamic.forEach(function (item, index) {
                if (item.percent > 0) {
                    pass = true;
                }
            })

            if (pass) {
                $(this).parents(".desired-allocation").find(".report02 img").addClass("hide");
                $(this).parents(".desired-allocation").find(".report02 .pie-chart-dynamic").removeClass("hide");

                drawPieChartDynamic();
            }
            else {
                $(this).parents(".desired-allocation").find(".report02 img").removeClass("hide");
                $(this).parents(".desired-allocation").find(".report02 .pie-chart-dynamic").addClass("hide");
            }
        })

        $(".list-title input[type='checkbox']").click(function () {
            $(this).parents(".list-title").next().find("input[type='checkbox']").prop("checked", this.checked);
        })

        // select radio in first step
        $("input[type='radio']").click(function () {
            //desktop view
            if ($(this).attr("id") === 'boxx01'
                || $(this).attr("id") === 'boxx06') {
                $("#boxx01").prop("checked", this.checked);
                $("#boxx06").prop("checked", this.checked);

                $(".step-by-step").eq(0).removeClass("hide");
                $(".step-by-step").eq(1).addClass("hide");
            }

            if ($(this).attr("id") === 'boxx02'
                || $(this).attr("id") === 'boxx07') {
                $("#boxx02").prop("checked", this.checked);
                $("#boxx07").prop("checked", this.checked);

                $(".step-by-step").eq(0).addClass("hide");
                $(".step-by-step").eq(1).removeClass("hide");
            }

            //mobile view
            if ($(this).attr("id") === 'cbox50'
                || $(this).attr("id") === 'cbox25') {
                $("#cbox50").prop("checked", this.checked);
                $("#cbox25").prop("checked", this.checked);

                $(".step-by-step-mobi").eq(0).removeClass("hide");
                $(".step-by-step-mobi").eq(1).addClass("hide");
            }

            if ($(this).attr("id") === 'cbox51'
                || $(this).attr("id") === 'cbox26') {
                $("#cbox51").prop("checked", this.checked);
                $("#cbox26").prop("checked", this.checked);

                $(".step-by-step-mobi").eq(0).addClass("hide");
                $(".step-by-step-mobi").eq(1).removeClass("hide");
            }
        })

        // click Cancel/Previous buttons in Desktop view
        $(".btn-cancel,\
       .btn-previous-step").click(function () {
                var index = 0;
                var step_content;
                var step_container;
                if ($(window).width() >= 1024) {
                    step_content = $(this).parents(".step-by-step").find(".step-content");
                    index = $(this).parents(".step-by-step").find(".step-content").index($(this).parents(".step-content"));
                    step_container = $(this).parents(".step-by-step");
                } else {
                    step_content = $(this).parents(".step-by-step-mobi").find(".step-mobile-content");
                    index = $(this).parents(".step-by-step-mobi").find(".step-mobile-content").index($(this).parents(".step-mobile-content"));
                    step_container = $(this).parents(".step-by-step-mobi");
                }

                if (index === 0) {
                    location.href = "/Account/FundExchange";
                } else {
                    index--;
                    step_content.addClass("hide");
                    step_content.eq(index).removeClass("hide");
                    resetSteps(step_container, index);
                }
       })


        // click add another exchange buttons in Desktop view
        $(".btn-add-another-exchange").click(function () {
           var step_content;
           var step_container;
           if ($(window).width() >= 1024) {
               step_content = $(this).parents(".step-by-step").find(".step-content");
               step_container = $(this).parents(".step-by-step");
           } else {
               step_content = $(this).parents(".step-by-step-mobi").find(".step-mobile-content");
               step_container = $(this).parents(".step-by-step-mobi");
           }
            var index = 1;
            step_content.addClass("hide");
            step_content.eq(index).removeClass("hide");
            resetSteps(step_container, index);
       })

        // click Next button in Desktop view
        $(".btn-next,\
       .btn-next-step").click(function () {
                var index = 0;
                var step_content;
                var total_step;
                var step_parent_content;
                var step_container;

                if ($(window).width() >= 1024) {
                    step_content = $(this).parents(".step-by-step").find(".step-content");
                    total_step = $(this).parents(".step-by-step").find(".step-content").length;
                    index = $(this).parents(".step-by-step").find(".step-content").index($(this).parents(".step-content"));
                    step_parent_content = $(this).parents(".step-content");
                    step_container = $(this).parents(".step-by-step");
                } else {
                    step_content = $(this).parents(".step-by-step-mobi").find(".step-mobile-content");
                    total_step = $(this).parents(".step-by-step-mobi").find(".step-mobile-content").length;
                    index = $(this).parents(".step-by-step-mobi").find(".step-mobile-content").index($(this).parents(".step-mobile-content"));
                    step_parent_content = $(this).parents(".step-mobile-content");
                    step_container = $(this).parents(".step-by-step-mobi");
                }

                if (index === total_step - 1) {
                } else {
                    if ($(this).hasClass("validate-all-positive-numeric")) {
                        var pass = true;
                        var input_list = step_parent_content.find("input[type='text']");
                        var select_list = step_parent_content.find("select");

                        input_list.each(function (index, item) {
                            if ($(item).val() !== '' && !isPositiveNum($(item).val())) {
                                $(item).parent().addClass("error-ver");
                                pass = false;
                            }
                        })

                        select_list.each(function (index, item) {
                            console.log($(item).val() === 'Select')
                            if ($(item).val() === 'Select') {
                                $(item).parent().css("border", "1px solid red");
                                pass = false;
                            }
                            else {
                                $(item).parent().removeAttr("style");
                            }
                        })

                        if (step_content.find(".second-content,.second-group").hasClass("error")) {
                            pass = false;
                        }

                        if (!pass) {
                            return;
                        }
                    }

                    index++;

                    // submit form when button marked with special class
                    if ($(this).hasClass('btn-submit-form-ajax')) {
                        var form = $(this).closest('form');
                        if (form.valid()) {
                            ajaxSubmit(form, function (response) {
                                step_content.addClass("hide");
                                step_content.eq(index).removeClass("hide");
                                resetSteps(step_container, index);
                            });
                        }
                    }
                    else {
                        step_content.addClass("hide");
                        step_content.eq(index).removeClass("hide");
                        resetSteps(step_container, index);
                    }
                }
            })

        // input value in input boxes
        $(".number-only").keyup(function () {
            var parent_section = $(this).parents(".left-content");
            parent_section.parent().removeClass("error");

            var total = 0;
            parent_section.find(".number-only").each(function () {
                if ($(this).val() !== "") {
                    total += parseInt($(this).val());
                    $(this).parent().addClass("show-percent");
                }
            });
            parent_section.find(".box-total .percent .title.right:eq(1), \
                           .box-total .percent .zero, \
                           .box-total .percent .value").text(total + "%");
            if (total > 100) {
                parent_section.parent().addClass("error");
            }
        });
    }

    // reset step status
    function resetSteps(container, index) {
        var list = container.find(".nested-circle ul li");

        list.removeClass("done current");
        for (var i = 0; i < index; i++) {
            list.eq(i).addClass("done");
        }
        list.eq(index).addClass("current");
    }

    // is positive numeric
    function isPositiveNum(value) {
        var re = /^[0-9]+$/;
        return re.test(value);
    }



    //=============== Withdrawals Create Page ===============
    //=============== Withdrawals Edit Page ===============
    if ($(".withdrawals-create,.withdrawals-edit").length > 0) {
        $(".datepicker-birth").datepicker({
            dateFormat: "dd/mm/yy",
            showOtherMonths: true
        });

        // select radio in Step 1
        $("#boxx01, #boxx02,\
      #cbox50, #cbox51").click(function () {
                var parent_section = $(this).parents(".bank-deposit-information");
                if ($(this).attr("id") === "boxx01" || $(this).attr("id") === "cbox50") {
                    $(".payment-frequency-hide").show();
                }

                if ($(this).attr("id") === "boxx02" || $(this).attr("id") === "cbox51") {
                    $(".payment-frequency-hide").hide();
                }
            })

        // select radio in "Bank Deposit Information" of Step 2
        $("#directdepositorcheck01, #directdepositorchec02,\
      #directdepositorcheck03, #directdepositorchec04").click(function () {
                var parent_section = $(this).parents(".bank-deposit-information");
                if ($(this).attr("id") === "directdepositorcheck01" || $(this).attr("id") === "directdepositorcheck03") {
                    parent_section.find("li:eq(1),li:eq(2),li:eq(3),li:eq(4)").removeClass("hide");
                    parent_section.find(".tip-info").addClass("hide");
                    parent_section.prev().removeClass("hide");

                    parent_section.parent().removeAttr("style");
                }

                if ($(this).attr("id") === "directdepositorchec02" || $(this).attr("id") === "directdepositorchec04") {
                    parent_section.find("li:eq(1),li:eq(2),li:eq(3),li:eq(4)").addClass("hide");
                    parent_section.find(".tip-info").removeClass("hide");
                    parent_section.prev().addClass("hide");

                    parent_section.parent().css("height", "146px");
                }
            });
        $('input[name="DepositOption"]:checked').click();

        // select radio button in Step 2
        $(".enter-payment-option .box-radio input[type='radio'],\
       .fund-selection .box-radio input[type='radio']").click(function () {
                var radio_group = $(this).parent();
                var input_group = radio_group.next();
                var index = radio_group.find("input[type='radio']").index($(this));
                input_group.find("div").find("input,.dropdown-here,.drop-input").addClass("disabled");
                input_group.find("div").eq(index).find("input,.dropdown-here,.drop-input").removeClass("disabled");
            });
        $(".enter-payment-option .box-radio input[type='radio']:checked,\
       .fund-selection .box-radio input[type='radio']:checked").click();

        // click Modify button in Step 2
        $(".modify-btn").click(function () {
            var list = $(this).next().find("li");
            list.eq(1).find(".typing-here input").toggleClass("hide");
            list.eq(1).find(".typing-here span").toggleClass("hide");

            list.eq(2).find(".typing-here input").toggleClass("hide");
            list.eq(2).find(".typing-here span").toggleClass("hide");
        })

        // click checkbox to enable Next button
        $("input[type='checkbox']").click(function () {
            var next_btn = $(this).parents(".step-content,.step-mobile-content").find(".btn-next");
            if ($(this).prop('checked') === true) {
                next_btn.removeClass("disabled");
            }
            else {
                next_btn.addClass("disabled");
            }
        })

        // type in enter code input to enable Verify button
        $(".enter-code-input").keyup(function () {
            var verify_btn = $(this).parents(".step-content,.step-mobile-content").find(".btn-next");

            if (isPositiveNum($(this).val()) && $(this).val().length === 4) {
                verify_btn.removeClass("disabled");
            }
            else {
                verify_btn.addClass("disabled");
            }
        })

        // click Cancel/Previous buttons in Desktop view
        $(".btn-cancel,\
       .btn-previous-step").click(function () {
                var index = 0;
                var step_content;
                var step_container;
                if ($(window).width() >= 1024) {
                    step_content = $(this).parents(".step-by-step").find(".step-content");
                    index = $(this).parents(".step-by-step").find(".step-content").index($(this).parents(".step-content"));
                    step_container = $(this).parents(".step-by-step");
                } else {
                    step_content = $(this).parents(".step-by-step-mobi").find(".step-mobile-content");
                    index = $(this).parents(".step-by-step-mobi").find(".step-mobile-content").index($(this).parents(".step-mobile-content"));
                    step_container = $(this).parents(".step-by-step-mobi");
                }

                if (index === 0) {
                    location.href = "/Account/Withdrawals?withMockWithDrawals=true";
                } else {
                    index--;
                    step_content.addClass("hide");
                    step_content.eq(index).removeClass("hide");
                    resetSteps(step_container, index);
                }
            })

        // handle click on Try Again in Withdrawal pages
        $(".try-again-withdrawal").click(function () {
            var stepByStep = $(this).closest('.step-by-step');
            if (!stepByStep.length) {
                stepByStep = $(this).closest('.step-by-step-mobi');
            }
            var sendCodeBtn = $('.send-code-form', stepByStep);
            var form = sendCodeBtn.closest('form');
            ajaxSubmit(form, function (response) {
                // notify user that code is sent if needed
            });
        });

        // click Next button in Desktop view
        $(".btn-next,\
       .btn-next-step").click(function () {
                var index = 0;
                var step_content;
                var total_step;
                var step_parent_content;
                var step_container;
                var data_input_id;

                //window.scrollTo(0,0);

                var device_type;
                if ($(window).width() >= 1024) {
                    step_content = $(this).parents(".step-by-step").find(".step-content");
                    total_step = $(this).parents(".step-by-step").find(".step-content").length;
                    index = $(this).parents(".step-by-step").find(".step-content").index($(this).parents(".step-content"));
                    step_parent_content = $(this).parents(".step-content");
                    step_container = $(this).parents(".step-by-step");

                    data_input_id = "start-withdrawal-date01";
                    device_type = "desktop";
                } else {
                    step_content = $(this).parents(".step-by-step-mobi").find(".step-mobile-content");
                    total_step = $(this).parents(".step-by-step-mobi").find(".step-mobile-content").length;
                    index = $(this).parents(".step-by-step-mobi").find(".step-mobile-content").index($(this).parents(".step-mobile-content"));
                    step_parent_content = $(this).parents(".step-mobile-content");
                    step_container = $(this).parents(".step-by-step-mobi");

                    data_input_id = "start-withdrawal-date02";
                    device_type = "mobile";
                }

                if (index === total_step - 1) {
                } else {
                    if ($(this).hasClass("validate-all-positive-numeric")) {
                        var pass = true;
                        var input_list = step_parent_content.find("input[type='text']:not(.disabled):visible");
                        var select_list;
                        if (device_type === "desktop") {
                            select_list = step_parent_content.find(".dropdown-here:not(.disabled) select");
                        } else {
                            select_list = step_parent_content.find(".drop-input:not(.disabled) select");
                        }
                        var radio_group = step_parent_content.find(".box-radio");
                       
                        var withholdingPercentage, additionalWithholding, noOfallowances;
                        var withholdingPercentageContainer, additionalWithholdingContainer, noOfallowancesContainer;
                        input_list.each(function (index, item) {                           
                            if ($(item).attr("id") === data_input_id) {
                                if ($(item).val() === "") {
                                    $(item).parent().addClass("error-ver");
                                    pass = false;
                                }
                            } else if ($(item).attr("id") === "number-of-allowances"
                                || $(item).attr("id") === "number-of-allowances01") {
                                noOfallowances = $(item).val();
                                noOfallowancesContainer = $(item).parent();

                            } else if ($(item).attr("id") === "additional-withholding"
                                || $(item).attr("id") === "additional-withholding02") {
                                additionalWithholding = $(item).val();
                                additionalWithholdingContainer = $(item).parent();
                            } else if ($(item).attr("id") === "withholding-percentage01"
                                || $(item).attr("id") === "withholding-percentage02") {
                                withholdingPercentage = $(item).val();
                                withholdingPercentageContainer = $(item).parent();
                            }
                            else if ($(item).hasClass("percentage-type")) {
                                if (($(item).val() === "")
                                    || (!isPositiveNum($(item).val()))
                                    || (isPositiveNum($(item).val()) && (parseInt($(item).val()) > 100 || parseInt($(item).val()) < 0))) {
                                    $(item).parent().addClass("error-ver");
                                    pass = false;
                                }
                            } else {
                                if (($(item).val() === '') || (!isPositiveNum($(item).val()))) {
                                    $(item).parent().addClass("error-ver");
                                    pass = false;
                                }
                            }
                        });
                        var invalidWithholidingPercentage = false;
                        var invalidNoOfAllowances = false;
                        var invalidAdditionalWithHolding = false;
                        if (!withholdingPercentage || !isPositiveNum(withholdingPercentage)
                            || parseInt(withholdingPercentage) > 100 || parseInt(withholdingPercentage) < 0)
                        {
                            invalidWithholidingPercentage = true;
                            $(withholdingPercentageContainer).addClass("error-ver");
                        }
                        if(!(noOfallowances && isPositiveNum(noOfallowances))){
                            invalidNoOfAllowances = true;
                            $(noOfallowancesContainer).addClass("error-ver");
                        }
                        if(!(additionalWithholding && isPositiveNum(additionalWithholding))){
                            invalidAdditionalWithHolding = true;
                            $(additionalWithholdingContainer).addClass("error-ver");
                        }

                       if (!invalidWithholidingPercentage
                            || !(invalidNoOfAllowances || invalidAdditionalWithHolding)) {
                            $(withholdingPercentageContainer).removeClass("error-ver");
                            $(noOfallowancesContainer).removeClass("error-ver");
                            $(additionalWithholdingContainer).removeClass("error-ver");
                        } else {
                            pass = false;
                        }

                        select_list.each(function (index, item) {
                            if (device_type === "desktop") {
                                if ($(item).val() === 'SELECT') {
                                    $(item).parent().css("border", "1px solid red");
                                    pass = false;
                                }
                                else {
                                    $(item).parent().removeAttr("style");
                                }
                            } else {
                                if ($(item).val() === 'Select') {
                                    $(item).parent().find(".ui-button").css("border", "1px solid red");
                                    pass = false;
                                }
                                else {
                                    $(item).parent().find(".ui-button").removeAttr("style");
                                }
                            }

                            if ($(item).val() === 'SELECT') {
                                $(item).parent().css("border", "1px solid red");
                                pass = false;
                            }
                            else {
                                $(item).parent().removeAttr("style");
                            }
                        })

                        if (!pass) {
                            return;
                        }
                    }

                    index++;

                    // validate form, and post if needed
                    if ($(this).hasClass('validate-model-form')) {
                        var form = $(this).closest('form');
                        if (form.valid()) {
                            nextStep(index, step_content, step_container);
                        }
                    }
                    else if ($(this).hasClass('send-code-form')) {
                        // request validation code, if form is valid
                        var that = $(this);
                        var form = that.closest('form');
                        if (!form.valid()) {
                            return;
                        }

                        ajaxSubmit(form, function (response) {
                            nextStep(index, step_content, step_container);
                        });
                    }
                    else if ($(this).hasClass('validate-code-form')) {
                        // submit Validation code, if form is valid
                        var that = $(this);
                        var form = that.closest('form');
                        if (!form.valid()) {
                            return;
                        }

                        ajaxSubmit(form, function (response) {
                            var stepByStep = that.closest('.step-by-step');
                            if (!stepByStep.length) {
                                stepByStep = that.closest('.step-by-step-mobi');
                            }
                            var accessCodeInput = $('input[name="AccessCode"]', stepByStep);
                            accessCodeInput.val(response.content.accessCode);
                            var modelForm = accessCodeInput.closest('form');
                            ajaxSubmit(modelForm, function (response) {
                                $('.confirmation-code').text(response.content);
                                nextStep(index, step_content, step_container);
                            });
                        });
                    }
                    else {
                        nextStep(index, step_content, step_container);
                    }
                }
            });

        var nextStep = function (index, step_content, step_container) {
            step_content.addClass("hide");
            step_content.eq(index).removeClass("hide");
            resetSteps(step_container, index);
        };
    }

    //=============== Withdrawals View Page ===============
    if ($(".view-withdrawal").length > 0) {
        $("button.edit").click(function () {
            location.href = "/Account/EditWithdrawal";
        })
    }

    // handle submit button click for all forms
    $('.submit-form').click(function () {
        $(this).closest('form').submit();
    });

    $('.tick-me').click(function () {
        var t = $(this);
    });

    // handle click on Try Again in Step 3
    $("#change-form-step3 .try-again").click(function () {
        var form = $('#change-form-step2');
        ajaxSubmit(form, function (response) {
            // notify user that code is sent if needed
        });
    });

    $('#pwd-btn').click(function () {
        var newpwd = $('#new-pwd input').val();
        var conpwd = $('#con-pwd input').val();
        if (!newpwd || !conpwd || newpwd !== conpwd) {
            $('#new-pwd input').addClass("error-ver");
            $('#con-pwd input').addClass("error-ver");
        }
        else {
            $('#new-pwd input').removeClass("error-ver");
            $('#con-pwd input').removeClass("error-ver");
            $('#success-pwd').show();
            $('#pwd-fleids').hide();
           // $('#bottomBtnContainer').hide();
        }
    });
})

if (jQuery.validator && jQuery.validator.setDefaults) {
    jQuery.validator.setDefaults({
        focusInvalid: false,
        highlight: function (element) {
            $(element).parent().addClass("error-ver");
        },
        unhighlight: function (element) {
            $(element).parent().removeClass("error-ver");
        },
        submitHandler: function (form) {
            var theForm = $(form);
            if (theForm.attr('ajax') === 'true') {
                $(form).ajaxSubmit();
            }
            else {
                form.submit();
            }
        }
    });
}

// =========== Map ==================
var map;
var marker;
var icons = "/Content/i/marker.png";
var coordinates = {
    lat: 39.959813,
    lng: -82.992827
};

function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: {
            lat: -34.397,
            lng: 150.644
        },
        zoom: 8
    });
    geocodeAddress(map);
}

function geocodeAddress(resultsMap) {
    var geocoder = new google.maps.Geocoder();
    var address = document.getElementById('text-address').textContent;
    geocoder.geocode({
        'address': address
    }, function (results, status) {
        if (status === 'OK') {
            resultsMap.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: resultsMap,
                position: results[0].geometry.location,
                icon: icons,
            });
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}