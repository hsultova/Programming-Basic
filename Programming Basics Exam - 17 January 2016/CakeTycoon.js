function solve(input){
	
	var numberOfCakes = parseInt(input[0]);
	var flourNeeded = Number(input[1]);
	var flour = parseInt(input[2]);
	var truffles = parseInt(input[3]);
	var priceTruffle = parseInt(input[4]);

	var cakesToMake = flour / flourNeeded;

	if (Math.floor(cakesToMake) >= numberOfCakes)
	{
		var trufflesCost = priceTruffle * truffles;
		var cakePrice = ( trufflesCost / numberOfCakes) * 1.25;
		console.log("All products available, price of a cake: %s", cakePrice.toFixed(2));
	}
	else
	{
		var totalFlour = numberOfCakes * flourNeeded;
		var kilogramsNeeded = totalFlour - flour;
		console.log("Can make only %s cakes, need %s kg more flour", Math.floor(cakesToMake), kilogramsNeeded.toFixed(2)); 
	}
}