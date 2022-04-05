let allSlider =$(".slider").toArray();
let sliderIndex=0;
console.log(allSlider);
 function sliderSow(x){
    for(let i = 0; i< allSlider.length; i++){
        allSlider[i].classList.add("slider1")
    } 
   allSlider[x].classList.remove("slider1");
 }
 
 sliderSow(sliderIndex);

 $("#prevSlide").click(function(){
     if(sliderIndex==0){
        sliderIndex=allSlider.length
     }
     sliderSow(--sliderIndex);
 })

 $("#nextSlide").click(function(){
     if(sliderIndex==allSlider.length-1){
         sliderIndex=-1
     }
     sliderSow(++sliderIndex);
 })