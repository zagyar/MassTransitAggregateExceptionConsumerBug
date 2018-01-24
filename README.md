# MassTransitAggregateExceptionConsumerBug
Minimal repro of MT 4 bug for the report

Clone of original project from: https://github.com/MassTransit/Sample-RequestResponse

Requirements:
	install RabbitMQ
	Create vhost test or change App.config to appropriate vhost
	add permissions to your vhost to guest or set it properly in config
	
Scenario: 
	when client with MT 4+ consume message and cosumer throws AggregateException 
	the message is not moved to the _error queue and left Unacked 
	- hence consumed in ininite loop