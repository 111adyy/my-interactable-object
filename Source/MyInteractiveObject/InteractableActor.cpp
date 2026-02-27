// Fill out your copyright notice in the Description page of Project Settings.


#include "InteractableActor.h"
#include "MyInteractiveObjectCharacter.h"
#include "Camera/CameraComponent.h"
// Sets default values
AInteractableActor::AInteractableActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
	Mesh = CreateDefaultSubobject<UStaticMeshComponent>(FName("Mesh"));
	RootComponent = Mesh;
	Mesh->SetEnableGravity(true);
	Mesh->SetSimulatePhysics(true);
}

// Called when the game starts or when spawned
void AInteractableActor::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AInteractableActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}
void AInteractableActor::Interact(AActor* Interactor)
{
	UE_LOG(LogTemp, Warning, TEXT("Interact Actor"));
	if (AMyInteractiveObjectCharacter* CastedInteractor = Cast<AMyInteractiveObjectCharacter>(Interactor))
	{
		UE_LOG(LogTemp, Warning, TEXT("Interact inside"));
		FVector LookAxis = CastedInteractor->GetFirstPersonCameraComponent()->GetForwardVector();
		Mesh->AddImpulse(LookAxis * 500.0f, NAME_None, true);
	}
}

