Connect-AzAccount

Set-AzContext -Subscription <subscription name or id>

New-AzResourceGroupDeployment -ResourceGroupName <resource-group-name> -TemplateFile <path-to-template>