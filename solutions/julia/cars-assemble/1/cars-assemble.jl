function success_rate(speed)
    if speed ≤ 0
        return 0
    elseif 1 ≤ speed ≤ 4
        return 1
    elseif  5 ≤ speed ≤ 8
        return 0.9
    elseif speed == 9
        return 0.8
    else
        return 0.77
    end
end

const cars_ratio = 221
function production_rate_per_hour(speed)
    speed * cars_ratio * success_rate(speed) 
end

function working_items_per_minute(speed)
    Int64(production_rate_per_hour(speed) ÷ 60)
end
