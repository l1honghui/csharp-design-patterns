﻿# 基于队列的负载均衡

## 意图
使用队列充当任务与其调用的服务之间的缓冲区，以平滑间歇性重负载，否则可能导致服务失败或任务超时。这种模式可以帮助最大程度地减少需求高峰对任务和服务的可用性和响应能力的影响。

## 适用性
- 此模式非常适合使用可能会导致过载的服务的任何类型的应用程序。 
- 如果应用程序期望服务以最小的延迟响应，则此模式可能不合适。