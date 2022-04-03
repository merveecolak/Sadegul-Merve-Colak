$(document).ready(function(){
    $(".html").click(function(){
        $(".boostrap").css("background-color","");
        $(".javascript").css("background-color","");
        $(".jquery").css("background-color","");
        $(".hakkımızda").css("background-color","");
        $(".iletisim").css("background-color","");
        
        $(".html").css("background-color","red");
        $("#html").css("display","block");

    })

    $(".boostrap").click(function(){ 
        $(".html").css("background-color","");
        $(".javascript").css("background-color","");
        $(".jquery").css("background-color","");
        $(".hakkımızda").css("background-color","");
        $(".iletisim").css("background-color","");
    
        $(".html").css("background-color","");
        $(".boostrap").css("background-color","red");
        $("#boostrap").css("display","block");



     })

    $(".javascript").click(function(){
        $(".boostrap").css("background-color","");
        $(".html").css("background-color","");
        $(".jquery").css("background-color","");
        $(".hakkımızda").css("background-color","");
        $(".iletisim").css("background-color","");
    
        $(".javascript").css("background-color","red")
        $("#javascript").css("display","block");
    })

    $(".jquery").click(function(){
        $(".boostrap").css("background-color","");
        $(".javascript").css("background-color","");
        $(".html").css("background-color","");
        $(".hakkımızda").css("background-color","");
        $(".iletisim").css("background-color","");
    
        $(".jquery").css("background-color","red")
        $("#jquery").css("display","block");

       
    })

    $(".hakkımızda").click(function(){
        $(".boostrap").css("background-color","");
        $(".html").css("background-color","");
        $(".jquery").css("background-color","");
        $(".hakhtmlımızda").css("background-color","");
        $(".iletisim").css("background-color","");
    
        $(".hakkımızda").css("background-color","red")
        $("#hakkımızda").css("display","block");
    })

    $(".iletisim").click(function(){
        $(".boostrap").css("background-color","");
        $(".html").css("background-color","");
        $(".jquery").css("background-color","");
        $(".hakkımızda").css("background-color","");
        $(".html").css("background-color","");
    
        $(".iletisim").css("background-color","red")
        $("#iletisim").css("display","block");
       
    })

    $(".ana").click(function(){
        $(".ana").css("background-color","red")
    })
})

