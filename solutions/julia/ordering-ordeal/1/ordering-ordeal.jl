function sortquantity!(qty)
    inxs = sortperm(qty, rev=true)
    sort!(qty, rev=true)
    inxs    
end

function sortcustomer(cust, srtperm)
    cust[srtperm]
end

function production_schedule!(cust, qty)
    inxs = sortperm(qty, rev=true)
    sortquantity!(qty)
    cust[inxs], invperm(inxs)
end
