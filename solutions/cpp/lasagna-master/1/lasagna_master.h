#pragma once
#include <vector>
#include <string>
namespace lasagna_master {

    struct amount {
        int noodles;
        double sauce;
    };

    int preparationTime(const std::vector<std::string>& layers, const int average_preparation=2);

    amount quantities(const std::vector<std::string>& layers);

    void addSecretIngredient(std::vector<std::string>& my_list,const std::vector<std::string>& friend_list);
    void addSecretIngredient(std::vector<std::string>& my_list, const std::string& secret_ingredient);

    std::vector<double> scaleRecipe(const std::vector<double>& quantities, const double num_portions);
}  // namespace lasagna_master
