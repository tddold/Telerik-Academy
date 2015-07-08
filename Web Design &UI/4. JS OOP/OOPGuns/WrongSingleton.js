var calculator = (function(){
  var instance;
    return{
        get: function(){
            if(typeof(instance) === 'undefined'){
                instance = {
                    result: 0,
                    add: function(x){
                        this.result +=x;
                    }
                };
            }
            return instance;
        }
    };
}());

calculator.get().add(5);
calculator.get().add(15);
calculator.get().add(25);

console.log(calculator.get().result);