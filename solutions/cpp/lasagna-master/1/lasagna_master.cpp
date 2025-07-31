#include "lasagna_master.h"

namespace lasagna_master {

    int preparationTime(const std::vector<std::string>& layers, const int average_preparation){
        return layers.size()*average_preparation;
    }
    
    amount quantities(const std::vector<std::string>& layers){
        amount needed{};
        for(size_t i=0;i<layers.size();++i){
            if(layers[i]=="sauce"){
                needed.sauce += 0.2;
            }
            else if(layers[i]=="noodles"){
                needed.noodles += 50;
            }
        }
        return needed;
    }

    void addSecretIngredient(std::vector<std::string>& my_list, const std::vector<std::string>& friend_list){
        my_list.back() = friend_list.back();
    }

    std::vector<double> scaleRecipe(const std::vector<double>& quantities, const double num_portions){
        std::vector<double> new_quantities{};
        for(size_t i=0;i<quantities.size();++i){
            double quantity = quantities[i] / 2.0;
            new_quantities.emplace_back(quantity*num_portions);
        }
        return new_quantities;
    }

    void addSecretIngredient(std::vector<std::string>& my_list, const std::string& secret_ingredient){
        my_list.back() = secret_ingredient;
    }
}  // namespace lasagna_master
