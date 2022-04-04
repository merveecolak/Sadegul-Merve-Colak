$(document).ready(function(){
let allSlider =$(".slider").toArray();

let sliderIndex=0;

console.log(allSlider);

 function sliderShow(x){
    for(let i = 0; i< allSlider.length; i++){
        allSlider[i].classList.add("slider1")
    } 
   allSlider[x].classList.remove("slider1");
 }
 
 sliderShow(sliderIndex);

 $("#prevSlide").click(function(){
     if(sliderIndex==0){
        sliderIndex=allSlider.length
     }
     sliderShow(--sliderIndex);
 })

 $("#nextSlide").click(function(){
     if(sliderIndex==allSlider.length-1){
         sliderIndex=-1
     }
     sliderShow(++sliderIndex);
 })

 
     $("#resim1").click(function(){
         $(".resim1").css("display","flex");     
     })

      $("#resim2").click(function(){
         $(".resim2").css("display","flex");
    
     })

     
     $("#resim3").click(function(){
        $(".resim3").css("display","flex");     
    })

     $("#resim4").click(function(){
        $(".resim4").css("display","flex");
   
    })
   
    $("#resim5").click(function(){
        $(".resim5").css("display","flex");     
    })

     $("#resim6").click(function(){
        $(".resim6").css("display","flex");
   
    })
   
    $("#resim7").click(function(){
        $(".resim7").css("display","flex");     
    })

     $("#resim8").click(function(){
        $(".resim8").css("display","flex");
   
    })
    $("#resim9").click(function(){
        $(".resim9").css("display","flex");     
    })

     $("#resim10").click(function(){
        $(".resim10").css("display","flex");
   
    })
   
    
 })