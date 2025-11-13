// Fill out your copyright notice in the Description page of Project Settings.


#include "TDTowerPawn.h"

// Sets default values
ATDTowerPawn::ATDTowerPawn()
{
 	// Set this pawn to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ATDTowerPawn::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ATDTowerPawn::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void ATDTowerPawn::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

