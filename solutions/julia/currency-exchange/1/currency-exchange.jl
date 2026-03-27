function exchange_money(budget, exchange_rate)
    budget / exchange_rate    
end

function get_change(budget, exchanging_value)
   budget - exchanging_value 
end

function get_value_of_bills(denomination, number_of_bills)
    denomination * number_of_bills
end

function get_number_of_bills(amount, denomination)
    amount ÷ denomination  
end

function get_leftover_of_bills(amount, denomination)
    amount % denomination 
end

function exchangeable_value(budget, exchange_rate, spread, denomination)
    percent_spread = spread / 100 
    exchange_rate_tax = percent_spread * exchange_rate 
    exchange_rate += exchange_rate_tax
    get_value_of_bills(
        denomination, 
        get_number_of_bills(
            exchange_money(budget, exchange_rate),
            denomination))
end
