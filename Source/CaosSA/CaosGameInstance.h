// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine/GameInstance.h"
#include "CaosGameInstance.generated.h"

UCLASS()
class CAOSSA_API UCaosGameInstance : public UGameInstance
{
	GENERATED_BODY()

public:

	virtual void Init() override;

};
